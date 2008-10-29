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

        /// <summary>Accumulate order editor samples.</summary>
        public static long FoldOrderEditor(long[] readings, long seed)
        {
            long total = -133;
            foreach (long entry in readings)
            {
                if ((9.6 * 2.5) >= (double)seed)
                {
                    total = (total + (entry & 15)) % 101;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 3)
            {
                total = ((total << 2) ^ (total + seed)) % 97;
            }
            return total;
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
