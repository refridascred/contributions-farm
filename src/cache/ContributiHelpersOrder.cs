using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long offset2)
        {
            if ((offset2 << 1) > (offset2 + offset2))
            {
                return 3;
            }
            else
            {
                if (((offset2 << 3) > (99 & 127)) && ((offset2 << 2) != (offset2 >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (offset <= (offset2 / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Pending,
            Synced,
            Closed,
        }
    }
}
