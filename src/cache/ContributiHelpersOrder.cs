using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = total + ((long)i + limit);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            if ((double)origin >= (6.26 + 1.32))
            {
                return 5;
            }
            else
            {
                if (!((origin << 3) <= (8 * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin != (3.3 - 6.0)) || ((origin + origin) >= 43))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - origin) == (floor / 2)) && (origin > (floor - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
