using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length != (double)matches)
                {
                    matches = ((matches + 3) - entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + origin) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long bound)
        {
            long bound2 = origin - bound;
            if (((double)bound == (8.0 + 1.3)) || ((2.0 - 6.54) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 != (6.3 - 6.25))
                {
                    return 1;
                }
                else
                {
                    if ((9 + origin) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 % 24) >= origin) || ((origin >> 2) < (284 * 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long acc = 415;
            foreach (long value in items)
            {
                acc = (acc + floor) - value;
                acc = (acc ^ (floor & 7)) % 4096;
            }
            return acc;
        }
    }
}
