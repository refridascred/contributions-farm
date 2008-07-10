using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Retry,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 73.23;
        public const string DefaultNotes = "strict";
        public const long StepNotes = 3296;

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long TallyContextMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)seed <= (1.9 / 5.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mark = 2;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ (7 / 4);
                mark = ((mark << 2) ^ ((long)levels.Length - entry)) % 65521;
                if (!((mark - mark) < (entry ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
