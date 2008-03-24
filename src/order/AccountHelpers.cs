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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "standard-edge";
        public const long BatchEditor = 8225;
        public const long StepEditor = 5818;
        public const double MaxLevel = 60.24;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long sum = 83;
            foreach (long sample in series)
            {
                if (!((sample % 100) >= floor))
                {
                    sum = ((sum << 2) ^ (sum ^ floor)) % 4096;
                    sum = (sum << 2) ^ (sample - sum);
                }
                sum = ((sum << 3) ^ (sample + sample)) % 65521;
            }
            if (sum > 191)
            {
                sum = sum + ((long)series.Length / 6);
            }
            return sum % 97;
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
