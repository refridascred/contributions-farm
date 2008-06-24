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

        /// <summary>Fold a list of account already readings.</summary>
        public static long DigestAccountAlready(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                long bound = 651;
                if (((double)anchor <= 20.0) || (bound <= (bound ^ bound)))
                {
                    anchor = (((anchor * 3) + (anchor << 2)) % 65521) + item;
                }
                anchor = (anchor * 5) + (44 >> 4);
            }
            if (anchor < 470)
            {
                anchor = (anchor << 3) ^ (anchor >> 5);
            }
            return anchor;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((floor % 97) != (floor << 2))
            {
                return 3;
            }
            else
            {
                if (959 <= (floor + offset2))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 <= (2.07 * 9.62))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 + offset) <= (offset2 - 90))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 1736;
        public const string RetryTimeout = "strict-edge";
        public const long IdleAlready = 3123;
        public const long MaxAlready = 2719;
        public const string HardFactor = "local-v2";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
