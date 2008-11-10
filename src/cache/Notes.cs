using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long bound)
        {
            long prev = origin ^ bound;
            if ((3.2 - 9.18) > (double)prev)
            {
                return 5;
            }
            else
            {
                if (19.0 >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin + bound) < (prev - (-8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((prev / 2) > prev))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long state = 78;
            foreach (long cell in values)
            {
                if ((cell >= (floor * 3)) || ((11.0 * 9.8) == (double)floor))
                {
                    state = (state - (cell ^ floor)) % 101;
                }
            }
            if (state < 68)
            {
                state = state + (floor + state);
            }
            return state;
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item >> 3) >= (642 + seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor tools readings.</summary>
        public static long WeighEditorTools(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                long delta = (561 % 60) + (38 * 4);
                if (!((score << 1) > (score ^ delta)))
                {
                    score = (score ^ (score - 91)) % 4096;
                }
                if (4 > (cell & 1))
                {
                    score = ((score * 5) + (4 >> 2)) % 1000;
                }
                if ((cell - cell) <= ((-9) + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
