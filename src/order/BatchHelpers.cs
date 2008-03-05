using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (double)71)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((bound / 8) > (seen - bound)) && ((double)datum == (double)(-30)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
