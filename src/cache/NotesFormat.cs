using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = ((score * 5) + score) - cell;
                score = (score + (score << 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Audit channel window readings against a rule.</summary>
        public static long CountChannelWindowMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (seen > (seen >> 4))
                {
                    seen = ((seen + 2) - sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
