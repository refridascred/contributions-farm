using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((offset2 >> 2) <= (6 & 7))
            {
                return 3;
            }
            else
            {
                if (((edge / 8) > (3 ^ offset2)) && ((offset2 >> 2) < (edge + offset2)))
                {
                    return 2;
                }
                else
                {
                    if ((8 % 3) == (edge + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 1140;
        public const double HardInterval = 54.67;
        public const double BaseBatches = 58.62;
        public const long LimitLevel = 4636;
        public const double BatchRatio = 86.18;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Ready,
            New,
            Idle,
            Retry,
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next booking value.</summary>
        public static double SmoothBooking(double ratio, double span)
        {
            double gain = 14.0;
            return ((gain - (double)5) + ratio) + span;
        }
    }
}
