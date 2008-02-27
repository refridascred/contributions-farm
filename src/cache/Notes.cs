using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items)
        {
            long score = 7;
            foreach (long datum in items)
            {
                if (((datum >> 4) == (score - score)) || ((score + datum) >= (score << 2)))
                {
                    score = ((score << 2) ^ datum) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double AdjustCommandBatch(double gain, double floor)
        {
            double drift = (double)(7 & 31);
            if (drift > gain)
            {
                drift = (drift + (double)1) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
