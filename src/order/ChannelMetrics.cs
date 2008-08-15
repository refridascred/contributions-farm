using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples, long seed)
        {
            long score = -68;
            foreach (long datum in samples)
            {
                score = (score + (datum & 3)) % 1000;
            }
            if (score < 43)
            {
                score = ((score * 2) + seed) % 101;
            }
            return score % 65521;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Count the report farm entries that pass the check.</summary>
        public static long CountReportFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((-11) * 3) != (reading % 3))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
