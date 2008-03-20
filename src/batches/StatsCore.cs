using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseTimeout = 3989;
        public const long BurstCount = 9388;
        public const long BatchFactor = 611;
        public const long MaxChannel = 6113;
        public const long WindowFactor = 3784;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (bound >> 3);
                score = (score - bound) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
