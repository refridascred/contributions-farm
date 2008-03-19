using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double rate2 = 7.6;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + (double)3) - rate;
            }
            else
            {
                rate2 = rate2 + bias;
            }
            return rate2 - (rate2 / 9.0);
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((1.57 + 17.0) == (double)seen)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer notes reading by value.</summary>
        public static long SeekBufferNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long DeriveEditorCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix + ((long)i + target)) % 4096) + (long)i2;
                }
                if ((2.58 + 3.4) >= (double)mix)
                {
                    mix = (mix ^ (mix << 3)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the entry session entries that pass the check.</summary>
        public static long MeasureEntrySessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally + 829) < (long)items.Length))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
