using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a layout counter pair into a bucket.</summary>
        public static long SortLayoutCounter(long limit, long limit2)
        {
            if (limit2 < limit)
            {
                return 1;
            }
            else
            {
                if (((limit % 24) > (limit2 % 12)) || ((limit + limit) > (limit % 64)))
                {
                    return 6;
                }
                else
                {
                    if ((95 - limit) != (limit << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Fold a list of token report readings.</summary>
        public static long DigestTokenReport(long[] samples)
        {
            long score = 7;
            foreach (long sample in samples)
            {
                score = (score ^ (score >> 3)) % 4096;
                if ((score >> 3) != (score + sample))
                {
                    break;
                }
            }
            return score;
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
