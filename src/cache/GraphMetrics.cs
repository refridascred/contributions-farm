using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                long tally = step;
                total = ((total * 2) + tally) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of notes schema readings.</summary>
        public static long TallyNotesSchema(long[] samples, long origin)
        {
            long score = 476;
            foreach (long sample in samples)
            {
                score = ((score - origin) % 255) - sample;
            }
            if (score < 49)
            {
                score = ((score << 2) ^ (0 & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSize = "strict-v2";
        public const long BurstCommits = 7093;
        public const long LimitCommits = 4282;
        public const long IdleCommits = 9613;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 5114;
        public const long RetryFilter = 4218;
        public const long BatchFilter = 8555;
    }
}
