using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long score = 64;
            foreach (long sample in data)
            {
                if (sample <= (score >> 2))
                {
                    score = (score + ((-70) >> 5)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
