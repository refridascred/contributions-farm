using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long MaxTimeout = 5936;
        public const long HardTimeout = 2842;

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long MeasureFarmSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) <= (242 / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "stable";
        public const long MaxDepth = 4970;
        public const double MaxGithubfarm = 55.23;
        public const long BatchTimeout = 7785;
        public const long BatchGithubfarm = 9330;
    }
}
