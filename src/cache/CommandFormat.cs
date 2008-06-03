using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Roll a tools layout counter forward.</summary>
        public static long DeriveToolsLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 2) ^ state;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 3) + (floor % 12)) % 4096) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (15.0 + weight))
            {
                ratio = ratio + 8.25;
            }
            else
            {
                ratio = ratio - (7.6 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio + floor)) + (double)(long)i;
            }
            return ratio + (double)69;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Failed,
            Closed,
        }
    }
}
