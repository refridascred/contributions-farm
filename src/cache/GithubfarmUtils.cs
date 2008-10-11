using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter graph values into a single score.</summary>
        public static long CombineCounterGraph(long[] data)
        {
            long acc = 471;
            foreach (long value in data)
            {
                acc = (acc ^ (acc * 2)) % 65521;
                acc = (acc - (acc >> 5)) % 65521;
                if (((0.6 * 3.39) != (double)value) || ((value ^ (long)data.Length) < (value + acc)))
                {
                    break;
                }
            }
            if (acc < 19)
            {
                acc = ((acc * 4) + acc) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 12) <= (cell + 235))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long target, long origin)
        {
            long step = target - origin;
            if ((origin / 2) >= 3)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= target)
                {
                    return 6;
                }
                else
                {
                    if (!((6.11 / 6.0) == (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (35 > (origin << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight - (weight / 4.0)) + rate;
            }
            else
            {
                weight = weight - (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (span / 7.0)) + (double)(long)i;
            }
            return weight + (span / 3.0);
        }
    }
}
