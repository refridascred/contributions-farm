using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = result + (limit - result);
                result = (result - (95 ^ 1)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
