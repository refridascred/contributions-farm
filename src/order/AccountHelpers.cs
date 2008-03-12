using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double bias = (double)(70 * 2);
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (offset - bias)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Blend two account cluster measurements.</summary>
        public static double ScaleAccountCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = (gain - 4.0) - floor;
            }
            return gain + gain;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Active,
        }
    }
}
