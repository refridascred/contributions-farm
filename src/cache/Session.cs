using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double bias2 = scale - bias;
            return bias2 - (double)9;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                long hits = (floor - (-14)) - state;
                if ((hits + hits) == (floor - floor))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc >> 3)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
