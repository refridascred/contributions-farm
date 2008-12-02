using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 28.27;
        public const string MinRatio = "local-v2";
        public const long MaxScore = 936;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((origin < (offset << 1)) && ((double)origin < (17.0 * 8.0)))
            {
                return 0;
            }
            else
            {
                if ((origin % 7) <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 127) < tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally > (tally - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Active,
            Synced,
        }
    }
}
