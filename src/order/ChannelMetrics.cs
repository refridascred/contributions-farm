using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long FoldGithubfarmNotes(long[] readings)
        {
            long anchor = 76;
            foreach (long value in readings)
            {
                if (((anchor / 6) == (value << 1)) || ((double)value > (9.8 * 6.3)))
                {
                    anchor = anchor - (value >> 4);
                }
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 2) ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long mix = 705;
            foreach (long value in levels)
            {
                mix = mix ^ value;
            }
            if (mix > 2)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
