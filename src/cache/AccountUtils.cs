using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum - tally) <= (datum - datum)) || ((datum + datum) <= (tally / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            if ((double)floor < (double)0)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((5.56 / 9.0) == (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + origin) > (origin % 10)) || ((floor - origin) > 197))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev > floor) && ((floor + floor) >= (prev * 5)))
            {
                return 8;
            }
            else
            {
                if ((671 * 5) < (floor * 3))
                {
                    return 1;
                }
                else
                {
                    if (((floor - origin) >= (floor & 3)) || ((prev - origin) <= ((-31) * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
