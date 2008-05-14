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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (target + mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
