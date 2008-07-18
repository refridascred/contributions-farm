using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a profile format value against two limits.</summary>
        public static long BucketProfileFormat(long floor, long target)
        {
            if ((floor > (floor - floor)) || (floor > 8))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) < target)
                {
                    return 8;
                }
                else
                {
                    if ((target / 9) <= 63)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)target >= (double)entry) || (target <= (entry ^ 0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
