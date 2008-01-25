using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 ^ (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count notes context pairs that satisfy a relation.</summary>
        public static long CompareNotesContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Idle,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Validate entry route readings against a bound.</summary>
        public static bool VerifyEntryRouteBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long BaseCommand = 6968;
        public const string BatchCommand = "standard-1";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
