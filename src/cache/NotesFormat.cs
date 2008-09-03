using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Synced,
            Idle,
            New,
            Closed,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long step2)
        {
            if (step <= 357)
            {
                return 7;
            }
            else
            {
                if (!((step2 % 10) > (700 & 63)))
                {
                    return 0;
                }
                else
                {
                    if ((0.5 + 2.56) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step & 3) < (step2 - step)) && (step < (step2 - step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long TotalCacheEntry(long[] readings)
        {
            long carry = 700;
            foreach (long value in readings)
            {
                carry = ((carry ^ carry) % 1000) ^ value;
            }
            return carry;
        }
    }
}
