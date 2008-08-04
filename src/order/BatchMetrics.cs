using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank queue order input into a small class.</summary>
        public static long ClassifyQueueOrder(long seed, long step)
        {
            if ((step - step) > step)
            {
                return 4;
            }
            else
            {
                if (step < (6 % 100))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (2.5 - 6.6))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items)
        {
            long mix = -681;
            foreach (long sample in items)
            {
                mix = (mix << 2) ^ (sample % 100);
                if ((sample >> 1) >= mix)
                {
                    mix = (mix * 3) + (mix << 3);
                }
                else
                {
                    mix = (mix + (sample & 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3207;
        public const long StepLevel = 1146;
        public const double BatchChannel = 23.4;
        public const long CacheSize = 7898;
        public const long CacheChannel = 1352;
    }
}
