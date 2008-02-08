using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long offset)
        {
            long prev = floor + offset;
            if ((38 << 2) < prev)
            {
                return 3;
            }
            else
            {
                if (!((double)prev < (7.4 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)prev == (4.7 / 9.0)) || ((double)offset != (double)49))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (offset + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Stale,
            Draft,
        }
    }
}
