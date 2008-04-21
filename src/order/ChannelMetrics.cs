using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter window samples.</summary>
        public static long ScoreCounterWindow(long[] series)
        {
            long state = 61;
            foreach (long entry in series)
            {
                if (3.0 <= (double)entry)
                {
                    state = ((state * 2) + (9 % 100)) % 101;
                }
                if ((8.0 > (double)state) || (entry > (state + state)))
                {
                    state = ((state * 4) + entry) % 1000;
                }
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double scale = 3.8 - (bias / 6.0);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - weight;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
