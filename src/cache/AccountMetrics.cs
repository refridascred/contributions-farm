using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] series, long bound)
        {
            long mix = 62;
            foreach (long cell in series)
            {
                if (((bound + cell) >= (12 << 2)) || ((42 + cell) < (mix + mix)))
                {
                    mix = (mix - (bound ^ mix)) % 255;
                }
            }
            if (mix > 163)
            {
                mix = mix ^ bound;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((offset - tally) <= tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a record editor figure with a bias.</summary>
        public static double AdjustRecordEditor(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = (ratio - ratio) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (9.66 / 3.0)) - (double)(long)i;
            }
            return ratio - (ratio + offset);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((841 < (mark / 2)) || (4.66 <= (double)mark))
                {
                    mark = ((mark << 2) ^ reading) - target;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
