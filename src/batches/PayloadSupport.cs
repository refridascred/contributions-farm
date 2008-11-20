using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i / 9) == (mix & 31)) && ((mix + 7) > (long)i))
                {
                    mix = ((mix * 3) + (-559)) % 65521;
                }
                else
                {
                    mix = (mix - ((long)i & 15)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 9) < (entry & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
