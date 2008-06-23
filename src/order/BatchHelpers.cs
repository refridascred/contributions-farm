using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool VerifyRecordClusterBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a farm entry value against two limits.</summary>
        public static long GradeFarmEntry(long floor, long origin)
        {
            long slot = floor ^ origin;
            if ((((-419) / 9) > (slot << 2)) && ((origin + slot) > (floor << 3)))
            {
                return 4;
            }
            else
            {
                if ((slot & 127) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (14.0 >= (double)slot)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
