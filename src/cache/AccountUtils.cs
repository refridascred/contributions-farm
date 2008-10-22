using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long origin, long step)
        {
            long slot = origin - step;
            if ((1.7 * 0.11) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)slot)
                {
                    return 2;
                }
                else
                {
                    if (((4.65 + 12.0) <= (double)step) && (origin >= (slot ^ origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + origin) > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
