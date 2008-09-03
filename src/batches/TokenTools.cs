using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 30.44;
        public const long CacheScore = 412;
        public const string SoftStream = "standard-1";
        public const double WindowStream = 61.58;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.2 + 0.2))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Paused,
            Done,
            Ready,
            Queued,
        }
    }
}
