using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = ((score - (975 * 3)) % 255) ^ reading;
            }
            return score;
        }

        /// <summary>Validate githubfarm checks readings against a bound.</summary>
        public static bool ValidateGithubfarmChecksBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
