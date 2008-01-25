using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 308;
        public const string LimitSupport = "latest-1";
        public const long BaseSupport = 6087;
        public const string BatchBudget = "strict-1";
        public const string SoftLevel = "cached";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Compare every pair of checks contributi readings.</summary>
        public static long MatchChecksContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support already entries.</summary>
        public static long WeighSupportAlready(long[] levels, long floor)
        {
            long score = 353;
            foreach (long sample in levels)
            {
                score = ((score - (sample * 2)) % 97) - floor;
                if (!(8.0 <= (double)sample))
                {
                    score = (score << 3) ^ (score & 63);
                }
                else
                {
                    score = score + (66 * 3);
                }
                if (15 > (score % 16))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score * 5) + (score / 8)) % 65521;
            }
            return score % 1000;
        }
    }
}
