using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i ^ target) < 1)
                {
                    mix = (mix + (target >> 4)) % 1000;
                    mix = ((mix << 2) ^ (target / 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up session queue samples.</summary>
        public static long OverlapSessionQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double bias2 = 5.75 * 5.02;
            return (bias2 - (bias2 - scale)) + bias;
        }
    }
}
