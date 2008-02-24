using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            long slot = step + target;
            if ((double)target > (double)164)
            {
                return 4;
            }
            else
            {
                if ((target - slot) < step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 6540;
        public const long CacheSchema = 1428;
        public const long HardLevel = 1880;
        public const string SoftSchema = "open-edge";
        public const long RetryWidth = 4525;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long mix = 19;
            foreach (long value in data)
            {
                mix = ((mix - mix) % 97) + value;
            }
            if (mix < (-22))
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a payload channel counter forward.</summary>
        public static long StepPayloadChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
