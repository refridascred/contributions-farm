using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((double)mark < (14.0 / 7.0)) && (mark >= (5 % 24))))
                {
                    mark = (mark - (99 ^ mark)) % 97;
                    mark = (mark - (mark / 5)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Failed,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry - target) <= (target - 50)) && ((9.99 + 2.23) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
