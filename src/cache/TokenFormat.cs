using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long seed)
        {
            if ((bound ^ bound) > (69 + seed))
            {
                return 4;
            }
            else
            {
                if (0 >= (seed / 9))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 60) != (76 - seed))
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

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (item << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
