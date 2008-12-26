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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 13.36;
        public const long StepLevel = 2014;
        public const long BurstRatio = 9135;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= drift)
            {
                drift = drift - (drift + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 0.05) + (double)(long)i;
            }
            return drift - (offset - drift);
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
