using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile layout readings.</summary>
        public static long TallyProfileLayout(long[] values, long floor)
        {
            long anchor = 59;
            foreach (long reading in values)
            {
                anchor = (((anchor * 2) + floor) % 4096) - reading;
            }
            if (anchor < 9)
            {
                anchor = (anchor - (anchor - 548)) % 1000;
            }
            return anchor % 65521;
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
