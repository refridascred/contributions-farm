using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long bound)
        {
            long carry = 92;
            foreach (long sample in samples)
            {
                if ((long)samples.Length >= bound)
                {
                    carry = (((carry << 2) ^ (0 + 6)) % 97) - sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 86.62;
        public const long BatchScore = 9057;
        public const long MaxRatio = 5923;
        public const long DefaultCluster = 5566;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)bound > (8.23 - 0.46)) && ((bound * 5) <= (170 * 4)))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= (double)3)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + 930) != (matches + matches))
                {
                    matches = ((matches + 1) ^ cell) - origin;
                }
            }
            return matches;
        }
    }
}
