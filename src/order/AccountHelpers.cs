using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long TotalFilterStream(long[] samples)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((result ^ 430) > 74)
                {
                    result = result - (result % 60);
                }
                else
                {
                    result = result - (value ^ result);
                }
            }
            return result % 97;
        }

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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Locked,
            Paused,
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

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6914;
        public const long SoftFactor = 9266;
        public const long HardRoute = 5454;

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
