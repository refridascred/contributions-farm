using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a session context counter forward.</summary>
        public static long DeriveSessionContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)seed < 4.41)
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long StepEntryBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (((mark + mark) % 255) + cell) + origin;
            }
            return mark;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
