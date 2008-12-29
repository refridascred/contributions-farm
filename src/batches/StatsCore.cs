using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 39.14;
        public const long IdleFactor = 5971;
        public const long IdleBatch = 4821;
        public const long DefaultBatch = 764;
        public const long StepBatch = 9913;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long seed)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = sum ^ (cell << 3);
                if (((sum + 32) == (seed & 3)) && ((double)seed > 3.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Closed,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Check that every githubfarm counter entry stays within the limit.</summary>
        public static bool GuardGithubfarmCounterLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Ready,
            Pending,
            Done,
        }
    }
}
