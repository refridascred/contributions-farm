using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum << 2);
                if (origin <= (origin + sum))
                {
                    sum = (sum << 2) ^ 3;
                    break;
                }
                else
                {
                    sum = sum + (origin >> 4);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            if ((offset * 2) > (2 + offset))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) < ((-1) + 693))
                {
                    return 1;
                }
                else
                {
                    if ((6.7 - 2.5) != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a cache entry counter forward.</summary>
        public static long DeriveCacheEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + (-97)) >= (57 * 2)) && ((double)value == (2.4 * 13.0))) || ((14 % 5) > (tally & 3)))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
