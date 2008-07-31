using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
