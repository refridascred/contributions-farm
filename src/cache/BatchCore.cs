using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format stats readings against a rule.</summary>
        public static long MeasureFormatStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count <= (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= (280 / 6)) && ((offset % 64) > (sample ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
