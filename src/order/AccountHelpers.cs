using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up tools metrics samples.</summary>
        public static long MatchToolsMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double gain = weight;
            if (gain >= (8.0 * 2.2))
            {
                gain = gain - (1.1 - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (double)74) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 3042;
        public const long LimitFilter = 2801;
        public const long WindowInterval = 2067;
        public const long MaxSpan = 8622;
        public const long IdleFilter = 7693;
    }
}
