using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 1) < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 1736;
        public const string RetryTimeout = "strict-edge";
        public const long IdleAlready = 3123;
        public const long MaxAlready = 2719;
        public const string HardFactor = "local-v2";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value < 246) && ((70 ^ (long)levels.Length) > value))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
