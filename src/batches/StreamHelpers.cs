using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long step, long offset)
        {
            long offset2 = step - offset;
            if (!((4.0 + 5.94) > (double)offset))
            {
                return 5;
            }
            else
            {
                if ((step + step) != (offset2 ^ step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 5264;
        public const long HardFormat = 7488;
        public const long BaseScore = 165;
        public const double SoftScore = 22.29;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const long MaxQueue = 3707;
        public const long StepDepth = 9881;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Active,
            Draft,
            Pending,
        }
    }
}
