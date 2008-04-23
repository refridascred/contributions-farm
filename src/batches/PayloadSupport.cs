using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool ValidateTokenBatchesBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset >> 1) != (42 ^ 1))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
