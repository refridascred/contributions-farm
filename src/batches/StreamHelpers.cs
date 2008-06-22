using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double drift = (gain + bias) * 1.58;
            if (drift <= drift)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (0.8 / 7.0);
            }
            return drift + (double)971;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Paused,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long floor)
        {
            long state = 743;
            foreach (long cell in series)
            {
                state = (((state ^ 7) % 65521) + cell) - floor;
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (96 << 1)) % 97;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = sum ^ (entry - sum);
                if ((double)sum != (14.0 / 9.0))
                {
                    sum = (sum + (entry + entry)) % 97;
                }
            }
            if (sum < 37)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
