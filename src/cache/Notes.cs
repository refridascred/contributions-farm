using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "alpha-v2";
        public const long MaxMetric = 9941;
        public const double WindowMetric = 67.65;

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long GradePayloadAccount(long bound, long target)
        {
            if ((double)bound >= (double)target)
            {
                return 4;
            }
            else
            {
                if ((1.0 * 2.0) < (double)target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            long span = seed ^ offset;
            if (((seed << 3) == (offset >> 3)) || ((15.0 + 3.43) != (double)seed))
            {
                return 2;
            }
            else
            {
                if (seed >= (span + (-544)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset < (3.1 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
