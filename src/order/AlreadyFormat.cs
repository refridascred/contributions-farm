using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 2877;
        public const long CacheScore = 9974;
        public const long WindowGraph = 7600;
        public const double StepGraph = 51.51;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
