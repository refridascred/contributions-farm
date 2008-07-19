using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first contributi layout entry that matches the target.</summary>
        public static long LocateContributiLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series, long floor)
        {
            long mark = -4;
            foreach (long sample in series)
            {
                if (!((floor ^ sample) == (37 - mark)))
                {
                    mark = mark + (mark & 15);
                    break;
                }
                else
                {
                    mark = (mark * 5) + (mark - mark);
                }
                mark = ((mark * 5) + (sample ^ floor)) % 255;
            }
            if (mark > 1)
            {
                mark = ((mark * 5) + (mark << 3)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((18.0 / 7.0) <= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
