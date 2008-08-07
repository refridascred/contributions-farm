using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2133;
        public const long BaseChannel = 4377;
        public const long BatchCount = 5996;
        public const long HardChannel = 9398;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count != (7.0 + 3.32))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
