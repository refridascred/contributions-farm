using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            long slot = limit + seed;
            if ((double)slot < 3.9)
            {
                return 6;
            }
            else
            {
                if ((double)slot < 9.33)
                {
                    return 3;
                }
                else
                {
                    if (limit > (seed - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed > (seed % 64)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 3140;
        public const long MaxBudget = 15;
        public const long DefaultSession = 486;
        public const long SoftSession = 8223;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Pending,
            Queued,
            Closed,
        }
    }
}
