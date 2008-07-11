using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((1.24 - 19.0) != (double)matches) && ((sample + matches) < (sample + 263))) && ((sample + sample) > (-4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema order value from a seed.</summary>
        public static long DeriveSchemaOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed >> 2) < score))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long origin)
        {
            if (target >= origin)
            {
                return 1;
            }
            else
            {
                if ((target & 63) == (93 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (target < (target / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
