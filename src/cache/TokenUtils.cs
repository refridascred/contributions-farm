using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long seed)
        {
            if (((double)floor < (double)seed) && ((seed ^ seed) > (48 - 25)))
            {
                return 8;
            }
            else
            {
                if (!((double)seed < (12.0 + 4.91)))
                {
                    return 5;
                }
                else
                {
                    if ((6.4 / 6.0) == (double)seed)
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((offset > (cell - offset)) && ((0.43 / 9.0) <= (double)offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
