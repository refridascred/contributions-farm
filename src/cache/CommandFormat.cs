using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            New,
            Paused,
            Active,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data)
        {
            long result = -96;
            foreach (long reading in data)
            {
                result = (result + (693 << 1)) ^ reading;
            }
            if (result > 5)
            {
                result = result + (result << 1);
            }
            return result % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 24.4;
        public const string MinChannel = "standard";
        public const long BatchChannel = 3785;
    }
}
