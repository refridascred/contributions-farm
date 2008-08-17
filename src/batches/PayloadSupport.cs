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

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
