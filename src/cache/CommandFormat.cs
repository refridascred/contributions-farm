using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Accumulate schema cache samples.</summary>
        public static long DigestSchemaCache(long[] items)
        {
            long mix = 918;
            foreach (long entry in items)
            {
                mix = (mix ^ (entry + entry)) % 101;
                mix = (mix - (entry + entry)) % 97;
                if (!(entry <= (mix - entry)))
                {
                    mix = mix ^ (4 - entry);
                }
                else
                {
                    mix = ((mix * 2) + (mix & 1)) % 1000;
                }
            }
            if (mix < 23)
            {
                mix = (mix ^ (mix >> 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings, long floor)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                if ((double)sample > 8.9)
                {
                    mark = mark - sample;
                    mark = (mark + (167 * 2)) % 101;
                }
                if ((double)floor <= 9.6)
                {
                    continue;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark >> 2)) % 97;
                }
                mark = ((mark << 3) ^ (mark + 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
