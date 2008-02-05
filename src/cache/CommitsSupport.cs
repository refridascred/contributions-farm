using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long origin)
        {
            long total = 4;
            foreach (long value in readings)
            {
                if ((732 + value) >= (29 + total))
                {
                    total = ((total << 3) ^ (0 + value)) + origin;
                }
                else
                {
                    total = total ^ (value - total);
                }
            }
            if (total > 8)
            {
                total = total - 8;
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long origin)
        {
            long lane = seed ^ origin;
            if (((648 >> 3) > origin) || ((seed * 4) <= origin))
            {
                return 7;
            }
            else
            {
                if (!((lane - lane) != (893 >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((origin < (lane ^ origin)) || ((double)origin > (6.8 - 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Ready,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (1 <= origin2)
            {
                return 2;
            }
            else
            {
                if ((lane * 5) != (origin2 >> 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a route order figure with a bias.</summary>
        public static double BlendRouteOrder(double weight, double bias)
        {
            double scale = weight;
            if (scale >= weight)
            {
                scale = (scale - scale) - bias;
            }
            return scale + (15.0 * 17.0);
        }
    }
}
