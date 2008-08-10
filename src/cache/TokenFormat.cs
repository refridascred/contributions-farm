using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a order account figure with a bias.</summary>
        public static double BlendOrderAccount(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight / 9.0)) - (double)(long)i;
            }
            return load + (load - weight);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long mix = 55;
            foreach (long datum in levels)
            {
                mix = (mix + (882 / 2)) - datum;
            }
            if (mix < 676)
            {
                mix = mix ^ (mix * 3);
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items, long origin)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((((mix << 3) ^ (mix + entry)) % 65521) ^ (long)i) - origin;
                }
                mix = ((mix << 2) ^ (mix << 2)) % 4096;
            }
            return mix;
        }
    }
}
