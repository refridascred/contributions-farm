using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = 677;
            foreach (long item in samples)
            {
                if (((score << 2) > (item % 10)) || ((double)score > (double)22))
                {
                    score = ((score << 3) ^ 46) % 101;
                }
            }
            if (score > 90)
            {
                score = ((score << 2) ^ (98 - (long)samples.Length)) % 97;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches * 4) != (entry + matches)) && ((9.4 + 1.3) >= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
