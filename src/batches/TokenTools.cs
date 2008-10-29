using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((19.0 - 15.0) <= (double)(long)i)
                {
                    acc = ((acc << 3) ^ (9 * 3)) % 101;
                    acc = (acc + acc) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long mix = 699;
            foreach (long entry in levels)
            {
                mix = (mix - (mix >> 4)) + entry;
            }
            return mix;
        }
    }
}
