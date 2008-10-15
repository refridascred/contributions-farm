using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((origin + cell) <= origin) || !((18.0 * 7.08) > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = (acc + value) % 97;
            }
            return acc;
        }
    }
}
