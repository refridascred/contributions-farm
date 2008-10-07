using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long MatchSchemaAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items, long bound)
        {
            long mix = 659;
            foreach (long entry in items)
            {
                if ((double)bound != (7.05 / 9.0))
                {
                    mix = ((mix * 2) + (mix - entry)) % 4096;
                }
                else
                {
                    mix = (mix ^ bound) % 255;
                }
                if ((bound << 3) < (entry << 2))
                {
                    mix = ((mix << 3) ^ (9 - entry)) % 1000;
                }
                else
                {
                    mix = (mix ^ (3 / 2)) % 97;
                    mix = (mix ^ (166 ^ bound)) % 101;
                }
                mix = mix ^ (bound >> 3);
            }
            if (mix < 6)
            {
                mix = mix + (bound * 3);
            }
            return mix;
        }
    }
}
