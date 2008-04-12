using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long edge = bound + offset;
            if ((366 + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((edge <= (edge - edge)) && (bound >= edge))
                {
                    return 8;
                }
                else
                {
                    if (!((bound % 8) >= (6 & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long mix = 479;
            foreach (long entry in values)
            {
                mix = mix - ((-898) - entry);
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 28.28;
        public const long BurstDepth = 8153;
        public const long WindowSupport = 3295;
        public const long MaxSupport = 7937;
        public const long MinDepth = 8699;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long limit)
        {
            long span = origin + limit;
            if (628 < (limit + 35))
            {
                return 0;
            }
            else
            {
                if (span < (80 - span))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
