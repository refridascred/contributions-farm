using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double weight = 3.0 * 8.94;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)2) + (double)(long)i) + offset;
            }
            return weight - (ratio / 8.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long entry in samples)
            {
                mix = (((mix * 3) + (floor - floor)) % 65521) ^ entry;
            }
            if (mix < (-24))
            {
                mix = mix + (mix + floor);
            }
            return mix % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
