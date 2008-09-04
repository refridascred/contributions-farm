using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit stream notes readings against a rule.</summary>
        public static long TallyStreamNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= (double)48)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double scale = (double)(-3) - (weight * 9.6);
            if (scale > (scale + bias))
            {
                scale = scale - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale / 2.0)) + (double)(long)i;
            }
            return scale + (bias + 5.0);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double scale = (double)(366 + 2);
            if (scale > scale)
            {
                scale = (scale - (double)0) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
