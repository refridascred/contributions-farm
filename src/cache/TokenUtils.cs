using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 65521;
                if ((double)origin <= (double)mix)
                {
                    mix = ((mix * 4) + mix) % 101;
                    break;
                }
                if (!((mix ^ mix) > (554 + mix)))
                {
                    mix = (mix + (origin + origin)) % 65521;
                    mix = (mix << 3) ^ (mix & 7);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) != (hits << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
