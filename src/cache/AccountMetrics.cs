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

        /// <summary>Audit session format readings against a rule.</summary>
        public static long TallySessionFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches > (matches - value)) || ((matches & 7) >= (value - value))))
                {
                    matches = matches + 3;
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
