using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long origin, long offset)
        {
            if ((((-5) + offset) != (offset - 403)) || ((-2) >= offset))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset ^ 59) >= (origin * 5)) && ((double)origin < (13.0 - 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.0 <= (double)offset)
                        {
                            return 0;
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
}
