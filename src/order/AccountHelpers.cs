using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 5664;
        public const long HardScore = 6316;
        public const long BurstLevel = 9808;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((881 >> 4) > (value - value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm route pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Queued,
            Closed,
        }
    }
}
