using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((limit - count) != (limit & 7))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = (score << 2) ^ score;
                score = ((score << 3) ^ (datum / 2)) % 97;
                score = (score * 4) + (datum ^ datum);
            }
            return score;
        }
    }
}
