using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (target & 255))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (count - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (score >> 2)) + (long)i;
                }
                score = score ^ score;
                score = (score ^ (item + (-36))) % 255;
            }
            if (score < 2)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
