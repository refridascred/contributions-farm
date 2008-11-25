using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long seed)
        {
            if (((bound + seed) < (124 + seed)) || ((double)seed >= (double)bound))
            {
                return 0;
            }
            else
            {
                if (!((0.72 / 9.0) <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound + seed) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ 14) > (bound << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order account entry stays within the limit.</summary>
        public static bool GuardOrderAccountRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            New,
        }
    }
}
