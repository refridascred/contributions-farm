using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the queue account entries that pass the check.</summary>
        public static long TallyQueueAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (5.94 <= 20.0)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long acc = 955;
            foreach (long reading in samples)
            {
                if ((acc * 2) <= 6)
                {
                    acc = ((acc - (acc & 31)) % 65521) - origin;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - reading)) % 97;
                }
            }
            return acc;
        }
    }
}
