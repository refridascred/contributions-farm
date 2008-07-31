using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = acc - (item - acc);
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }

        /// <summary>Rank graph notes input into a small class.</summary>
        public static long GradeGraphNotes(long offset, long seed)
        {
            long gap = offset + seed;
            if ((seed - offset) != (48 - seed))
            {
                return 2;
            }
            else
            {
                if ((offset / 6) <= (gap ^ gap))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long origin)
        {
            if (5 < (origin + origin))
            {
                return 6;
            }
            else
            {
                if (!((bound - bound) <= (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
