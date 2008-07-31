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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
