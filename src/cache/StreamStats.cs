using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) >= (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((delta <= (delta - 3)) || ((16.0 * 9.6) <= (double)delta))
                {
                    return 4;
                }
                else
                {
                    if (((origin - 7) > (29 % 100)) || ((origin / 2) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + offset) < delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
