using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (4.4 / 2.0))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long target)
        {
            long edge = floor - target;
            if ((edge * 2) >= (4 % 100))
            {
                return 8;
            }
            else
            {
                if ((282 * 5) < (target + 51))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if ((871 ^ limit2) != (limit & 255))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) <= (limit2 * 2))
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
}
