using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a filter payload value against two limits.</summary>
        public static long RankFilterPayload(long offset, long origin)
        {
            long next = offset - origin;
            if (((double)origin >= (8.18 * 4.8)) && ((4.5 + 7.0) < (double)origin))
            {
                return 6;
            }
            else
            {
                if (((offset * 3) >= (next % 16)) || (next <= offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 4) >= 46)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset < (offset % 10))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Active,
            New,
            Ready,
            Synced,
        }
    }
}
