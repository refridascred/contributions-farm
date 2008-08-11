using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 524;
            foreach (long item in data)
            {
                if ((item - sum) >= (item + sum))
                {
                    sum = sum - (sum & 255);
                }
                else
                {
                    sum = sum - (item % 12);
                }
            }
            return sum;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (31 > (sum - target))
                {
                    sum = (sum + (46 % 24)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a stats schema pair into a bucket.</summary>
        public static long ClassifyStatsSchema(long origin, long bound)
        {
            if ((bound + 232) <= (bound - origin))
            {
                return 2;
            }
            else
            {
                if ((4.07 - 5.7) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((588 - origin) <= (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound != (4.91 - 16.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings, long target)
        {
            long mix = 952;
            foreach (long value in readings)
            {
                mix = (mix ^ (mix + mix)) + target;
                if (!((value * 5) <= mix))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((9.4 + 5.0) < (double)matches) && !(cell <= 615))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
