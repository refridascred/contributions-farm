using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Draft,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "strict";
        public const long BatchBudget = 7356;
        public const double IdleInterval = 86.92;
        public const long HardWidth = 9213;
        public const long DefaultMetrics = 3704;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of farm entry readings.</summary>
        public static long TotalFarmEntry(long[] readings, long limit)
        {
            long total = 34;
            foreach (long item in readings)
            {
                if ((95 >> 1) > limit)
                {
                    total = (((total << 2) ^ limit) % 1000) - item;
                }
                else
                {
                    total = total - ((-9) * 4);
                }
            }
            if (total < 116)
            {
                total = total + (535 * 2);
            }
            return total % 4096;
        }
    }
}
