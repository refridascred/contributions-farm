using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values)
        {
            long mark = 971;
            foreach (long entry in values)
            {
                mark = (((mark << 3) ^ (mark & 7)) % 4096) + entry;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitLevel = "legacy-edge";
        public const long SoftFarm = 635;
        public const long HardFarm = 4449;
        public const double StepFarm = 21.58;
        public const long MaxFarm = 8586;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step != (double)sum)
                {
                    sum = (sum * 3) + (sum & 31);
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    sum = ((sum << 3) ^ (step & 63)) - (long)i3;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
