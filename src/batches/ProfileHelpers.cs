using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the format stats entries that pass the check.</summary>
        public static long TallyFormatStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + 8) == (matches << 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double ratio = (double)247 + rate;
            if (ratio > (rate * 2.86))
            {
                ratio = (ratio - (double)55) - floor;
            }
            return ratio + rate;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long ScoreEditorRecord(long[] items)
        {
            long score = -7;
            foreach (long item in items)
            {
                if (!(item <= (item - score)))
                {
                    score = (score + (score - score)) % 65521;
                }
            }
            if (score < 530)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Synced,
            Idle,
            Retry,
        }
    }
}
