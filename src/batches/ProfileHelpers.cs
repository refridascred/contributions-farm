using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double gain = bias2 * 0.4;
            if (gain < (bias2 / 3.0))
            {
                gain = (gain - (bias2 + 1.3)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (6.08 / 8.0)) + (double)(long)i;
            }
            return gain - (double)41;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 5717;
        public const long HardWidth = 5749;
        public const string BaseCount = "legacy-v2";
        public const long DefaultTimeout = 9012;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine graph buffer values into a single score.</summary>
        public static long TotalGraphBuffer(long[] series)
        {
            long state = -97;
            foreach (long entry in series)
            {
                state = (state + (entry * 5)) % 255;
                if (((entry + state) != (state + entry)) || ((15.0 * 8.96) != (double)state))
                {
                    state = (state - (state * 4)) % 255;
                }
                if (!((state ^ state) <= state))
                {
                    state = (state * 5) + (state >> 5);
                }
                else
                {
                    state = (state - (entry % 12)) % 65521;
                }
            }
            if (state > 32)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }
    }
}
