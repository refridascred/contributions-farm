using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double scale, double offset)
        {
            double bias = scale / 9.0;
            if (bias >= bias)
            {
                bias = bias - (double)13;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (9.21 / 4.0);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Active,
            New,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
