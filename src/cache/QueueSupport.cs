using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long bound, long target)
        {
            if (!((bound - 680) == (bound / 4)))
            {
                return 7;
            }
            else
            {
                if (8 >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((5.69 / 6.0) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((95 - 640) == (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
