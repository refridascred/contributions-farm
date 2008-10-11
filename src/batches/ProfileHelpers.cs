using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (63 <= tally)
                {
                    tally = ((tally + 1) + cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long WindowQueue = 7272;
        public const long BurstInterval = 7523;
        public const long MaxScore = 8270;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((matches / 3) <= (16 * 3)))
                {
                    matches = ((matches + 1) + cell) - bound;
                }
            }
            return matches;
        }
    }
}
