using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a profile report value against two limits.</summary>
        public static long SortProfileReport(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (((limit ^ limit) >= (limit % 2)) || ((double)edge < 6.7))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 13.0)
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 1) < origin)
                    {
                        return 2;
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
