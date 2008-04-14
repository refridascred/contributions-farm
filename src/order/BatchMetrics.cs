using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 9185;
        public const long HardScore = 7071;
        public const double RetryContext = 58.28;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = total + total;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ (total ^ total)) % 1000) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            long span = offset + seed;
            if (((5.12 * 3.0) < (double)span) && ((span & 63) > (seed % 5)))
            {
                return 4;
            }
            else
            {
                if ((-6) < (472 + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset - span) > (offset ^ span)) && ((span << 3) <= 19))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (double)span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7257;
        public const long BaseMetrics = 8474;
        public const long RetryMetrics = 5862;
    }
}
