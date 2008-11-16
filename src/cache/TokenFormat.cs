using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache graph entries.</summary>
        public static long DigestCacheGraph(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc * 5) + ((long)i >> 5);
                    acc = (acc + datum) % 65521;
                }
                acc = (acc + (datum - datum)) % 1000;
                acc = (acc - (acc % 60)) % 65521;
                if (!((6 / 8) >= acc))
                {
                    break;
                }
            }
            if (acc < 34)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mix = 92;
            foreach (long reading in levels)
            {
                mix = ((mix << 2) ^ (reading & 255)) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double ScaleRecordContext(double gain, double floor)
        {
            double drift = gain / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor + 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
