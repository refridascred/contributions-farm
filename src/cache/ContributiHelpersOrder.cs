using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 7087;
        public const double MinBudget = 16.36;
        public const long BatchSize = 8606;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
