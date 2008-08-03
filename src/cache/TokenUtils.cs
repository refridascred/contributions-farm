using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools payload readings.</summary>
        public static long CombineToolsPayload(long[] series, long step)
        {
            long state = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((((state * 5) + state) % 1000) + (long)i) - step;
                }
                state = (state ^ 3) % 4096;
                if (((1.4 - 8.0) == (double)sample) || ((sample % 24) < (state << 3)))
                {
                    state = (state << 2) ^ (state / 7);
                }
            }
            return state;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double weight = gain;
            if (weight > (3.3 + weight))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
