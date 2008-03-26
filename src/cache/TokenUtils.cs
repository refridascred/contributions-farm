using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound >= 18)
                {
                    mix = mix + (bound + mix);
                }
                else
                {
                    mix = (mix * 4) + (6 >> 1);
                    mix = (mix - (bound - 28)) % 1000;
                }
                if ((bound * 5) < (mix ^ (long)i))
                {
                    mix = ((mix * 2) + (mix * 3)) % 97;
                }
                else
                {
                    mix = (mix * 5) + (long)i;
                }
                mix = mix + (245 / 9);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long OverlapFormatChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
