using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a batches checks pair into a bucket.</summary>
        public static long SortBatchesChecks(long origin, long limit)
        {
            if (!((limit % 7) != (limit * 3)))
            {
                return 7;
            }
            else
            {
                if (limit > (origin * 3))
                {
                    return 6;
                }
                else
                {
                    if (limit > (origin - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long SoftCount = 5792;
        public const string StepRecord = "fallback-1";
        public const double DefaultRecord = 10.85;
        public const double MinRecord = 79.94;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long floor)
        {
            if (!((double)floor != (double)limit))
            {
                return 4;
            }
            else
            {
                if ((floor << 2) == (floor % 100))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
