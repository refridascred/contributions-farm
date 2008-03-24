using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count graph report pairs that satisfy a relation.</summary>
        public static long MatchGraphReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin * 5) <= (state + origin)))
                {
                    state = (state * 3) + origin;
                }
                if ((origin - (long)i) > (origin ^ state))
                {
                    state = (state - (origin + (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "stable";
        public const long IdleInterval = 1809;
        public const double StepCount = 1.86;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
