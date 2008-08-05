using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 627;
        public const long DefaultInterval = 4458;
        public const string RetryRatio = "staging-v2";

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long origin)
        {
            long mix = 903;
            foreach (long reading in data)
            {
                mix = ((mix * 2) + (origin + reading)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = (rate * 7.1) / 9.0;
            if (weight >= (double)7)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + (double)220;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate / 6.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long total = -223;
            foreach (long cell in levels)
            {
                if (total < 31)
                {
                    total = ((total + (666 * 5)) % 4096) - cell;
                }
                if ((2.9 + 7.33) != (double)total)
                {
                    total = (total + (total ^ total)) % 255;
                }
                else
                {
                    total = (total * 2) + (598 / 7);
                }
            }
            if (total < 192)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }
    }
}
