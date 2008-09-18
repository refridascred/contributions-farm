using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset % 60) < (matches + offset))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitLevel = "legacy-edge";
        public const long SoftFarm = 635;
        public const long HardFarm = 4449;
        public const double StepFarm = 21.58;
        public const long MaxFarm = 8586;

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                long matches = (sum + target) / 5;
                if (((long)i - matches) <= ((long)i - target))
                {
                    sum = (sum << 2) ^ (matches + 354);
                    sum = sum - 45;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
