using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Done,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally * 5) > (sample + (long)values.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9998;
        public const string IdleInterval = "strict-edge";
        public const double RetryLevel = 52.33;
        public const double RetryGithubfarm = 98.35;
    }
}
