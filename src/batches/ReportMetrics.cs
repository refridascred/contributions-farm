using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed + entry) == (entry & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                if ((11.0 - 0.1) >= (double)score)
                {
                    score = (score ^ (entry + entry)) % 255;
                }
            }
            return score;
        }
    }
}
