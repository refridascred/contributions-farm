using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value <= 71) && ((9.0 / 3.0) > (double)hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((total * 5) == (total >> 2))
                {
                    total = total - total;
                    break;
                }
                if (!(((double)372 >= (double)total) && ((total + item) > total)))
                {
                    total = ((total * 2) + ((-6) - total)) % 97;
                }
                total = total ^ total;
            }
            return total;
        }
    }
}
