using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            New,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Rank contributi order input into a small class.</summary>
        public static long SortContributiOrder(long step, long origin)
        {
            long slot = step + origin;
            if ((step % 60) != (slot + origin))
            {
                return 1;
            }
            else
            {
                if ((slot ^ origin) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((step / 9) < (step + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6 & 127) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long TallyAccountSession(long[] values, long offset)
        {
            long total = 72;
            foreach (long sample in values)
            {
                if (!((sample - sample) == (sample / 7)))
                {
                    total = (total - (50 >> 1)) - offset;
                }
            }
            return total % 4096;
        }
    }
}
