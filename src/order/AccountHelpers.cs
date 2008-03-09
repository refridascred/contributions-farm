using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long MatchContributiReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items)
        {
            long total = 524;
            foreach (long sample in items)
            {
                total = (total << 3) ^ (total + sample);
            }
            return total;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long state = 2;
            foreach (long sample in series)
            {
                if ((sample ^ sample) <= (state << 3))
                {
                    state = (state ^ (557 % 97)) % 97;
                }
            }
            if (state < 9)
            {
                state = (state << 2) ^ state;
            }
            return state % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardSize = 7820;
        public const double IdleSpan = 24.84;
        public const long WindowNotes = 8751;
        public const long BatchFactor = 3973;
        public const string RetryLevel = "cached-v2";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
