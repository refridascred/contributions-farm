using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Queued,
            Idle,
            Closed,
            New,
        }

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long RankPayloadGraph(long origin, long floor)
        {
            if (!((79 ^ floor) > floor))
            {
                return 0;
            }
            else
            {
                if (origin < floor)
                {
                    return 4;
                }
                else
                {
                    if (((double)floor != (7.19 - 1.6)) || ((origin & 31) <= (origin * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
