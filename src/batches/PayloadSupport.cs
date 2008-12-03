using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (acc + 946)) % 101;
                acc = ((acc << 2) ^ (seed * 2)) % 1000;
                acc = (acc << 2) ^ ((long)i + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double ratio = (double)997 + (17.0 / 9.0);
            if (ratio <= gain)
            {
                ratio = (ratio + (double)72) - offset;
            }
            return ratio + (double)(-9);
        }
    }
}
