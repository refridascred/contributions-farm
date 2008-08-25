using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Draft,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            if ((origin2 - origin2) <= (origin2 >> 4))
            {
                return 8;
            }
            else
            {
                if ((4.1 - 9.0) >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long prev = offset - seed;
            if ((prev << 2) >= offset)
            {
                return 0;
            }
            else
            {
                if (prev <= (offset + seed))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset < (11.0 / 8.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit < 4.2)
                {
                    anchor = ((anchor << 2) ^ (anchor & 7)) % 65521;
                    anchor = (anchor ^ (limit + limit)) % 101;
                }
                else
                {
                    anchor = (anchor + (-24)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
