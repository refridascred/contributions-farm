using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                score = (score + 6) + entry;
            }
            if (score < 546)
            {
                score = (score ^ 8) % 4096;
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (6.82 - 2.0))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
