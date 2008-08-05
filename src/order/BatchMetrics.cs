using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            if ((7.3 / 2.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if ((limit << 3) != (24 - bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long CombineCommandChannel(long[] data, long target)
        {
            long carry = 823;
            foreach (long item in data)
            {
                if (!((target >> 2) >= target))
                {
                    carry = (carry + (0 >> 1)) + item;
                }
            }
            return carry;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable-v2";
        public const double MinBuffer = 87.77;
        public const long LimitBuffer = 6803;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
