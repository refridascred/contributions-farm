using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit contributi route readings against a rule.</summary>
        public static long CountContributiRouteOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)cell < 6.2) && ((double)cell >= (17.0 - 7.3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long ClassifyNotesFarm(long bound, long step)
        {
            if (!((step + bound) >= bound))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= step)
                {
                    return 0;
                }
                else
                {
                    if (!((198 * 4) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step / 7) <= (step + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record layout input into a small class.</summary>
        public static long BucketRecordLayout(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((span / 5) >= floor)
            {
                return 5;
            }
            else
            {
                if (726 < origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 1) >= (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin / 5) < (-4)) && ((floor + 86) > (27 + span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
