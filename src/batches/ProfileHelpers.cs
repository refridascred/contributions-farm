using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((0 >> 1) == (matches - matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((step ^ step) < (step >> 4)))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + 969) > (item ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank queue batches input into a small class.</summary>
        public static long ClassifyQueueBatches(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if (((offset << 1) <= offset) && ((offset & 31) >= seed2))
            {
                return 0;
            }
            else
            {
                if ((double)seed2 < (4.2 * 11.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 3) == (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 2) <= (seed2 >> 1))
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

        /// <summary>Combine command stats values into a single score.</summary>
        public static long ScoreCommandStats(long[] items)
        {
            long score = 440;
            foreach (long reading in items)
            {
                score = score + (reading >> 2);
            }
            return score % 97;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
