using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools session entries.</summary>
        public static long WeighToolsSession(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = ((acc - 4) % 1000) - entry;
            }
            if (acc > 0)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches >> 1) < matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)mix <= (4.2 - 2.06))
                {
                    mix = mix ^ (limit + mix);
                    mix = mix ^ mix;
                }
                mix = ((mix * 3) + mix) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
