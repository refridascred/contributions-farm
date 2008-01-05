using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                if (((double)sample <= (2.3 - 4.2)) && ((sample - carry) == (sample % 5)))
                {
                    carry = carry - (7 ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 2849;
        public const long DefaultSupport = 170;
        public const long MaxInterval = 9355;
        public const long HardSpan = 796;
        public const long BurstFactor = 5723;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix * 5) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double ratio = gain - (double)6;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (offset + gain);
        }
    }
}
