using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((318 - cell) == (seen + seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi token figure with a bias.</summary>
        public static double AdjustContributiToken(double scale, double bias)
        {
            double ratio = bias;
            if (ratio > 12.0)
            {
                ratio = (ratio + (ratio + ratio)) + scale;
            }
            else
            {
                ratio = ratio - (12.0 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (6.9 / 3.0);
        }
    }
}
