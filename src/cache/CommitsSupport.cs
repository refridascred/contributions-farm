using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double SmoothToolsMetric(double ratio, double span)
        {
            double weight = (span - span) / 7.0;
            if (weight <= (span + weight))
            {
                weight = (weight + 3.04) + ratio;
            }
            return weight - span;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long seed)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                carry = (carry - (carry / 8)) % 97;
                carry = ((carry << 2) ^ (item ^ seed)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if (((seed - floor) < seed) || (floor < seed))
            {
                return 8;
            }
            else
            {
                if ((floor / 7) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed - floor) >= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3.0 - 8.16) < (double)floor) || ((15 + seed) == (floor / 2)))
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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long AuditTokenFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen - 11))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
