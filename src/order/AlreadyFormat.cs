using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long step)
        {
            long mark = 49;
            foreach (long reading in data)
            {
                mark = (mark ^ step) ^ reading;
                mark = (mark * 2) + (35 + mark);
            }
            if (mark > 48)
            {
                mark = mark - (550 ^ step);
            }
            return mark % 1000;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long MeasureFormatCommitsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((offset % 64) > offset)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long AuditLayoutCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((45 & 31) < item)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
