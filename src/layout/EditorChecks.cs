using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((943 - target) <= (sample + target)) || !((double)sample >= (1.42 + 1.53)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
