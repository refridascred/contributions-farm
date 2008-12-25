using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a stream cache sample.</summary>
        public static long SeekStreamCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(matches <= (long)readings.Length))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long result = 5;
            foreach (long datum in values)
            {
                result = ((result * 4) + (result << 2)) ^ datum;
            }
            return result % 4096;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5318;
        public const long MinDepth = 5564;
        public const long LimitInterval = 6473;
        public const double SoftWindow = 60.7;
        public const double MinBudget = 64.99;
    }
}
