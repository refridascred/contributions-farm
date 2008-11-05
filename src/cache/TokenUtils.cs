using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                mix = (mix + sample) % 97;
                if (!(2.0 < (double)mix))
                {
                    mix = (mix - (sample >> 4)) % 65521;
                }
                else
                {
                    mix = mix - (sample - mix);
                    mix = mix ^ (0 & 63);
                }
                mix = mix - (2 << 1);
                if ((81 + sample) < (mix << 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a batches route counter forward.</summary>
        public static long StepBatchesRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (origin <= (result % 5))
                {
                    result = result - (result * 5);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = (mix - (mix >> 2)) % 1000;
                if (mix >= (sample >> 3))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }
    }
}
