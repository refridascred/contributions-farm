using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long total = 84;
            foreach (long sample in levels)
            {
                if ((sample << 1) >= (total & 127))
                {
                    total = total - (5 / 8);
                }
            }
            return total;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next order command value.</summary>
        public static double SmoothOrderCommand(double bias, double floor)
        {
            double drift = (floor + floor) * 2.8;
            if (drift <= (bias + drift))
            {
                drift = drift - (double)28;
            }
            else
            {
                drift = drift - 16.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + (drift / 3.0);
        }
    }
}
