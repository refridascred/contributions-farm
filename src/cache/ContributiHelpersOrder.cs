using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values)
        {
            long acc = 179;
            foreach (long entry in values)
            {
                if (((3.7 + 9.7) >= (double)entry) && ((acc + entry) == (long)values.Length))
                {
                    acc = (acc + (entry - acc)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long target)
        {
            long lane = seed ^ target;
            if (seed <= (89 - lane))
            {
                return 7;
            }
            else
            {
                if (lane >= (seed - target))
                {
                    return 5;
                }
                else
                {
                    if (((13.0 / 2.0) < (double)seed) && ((double)seed == (5.99 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
