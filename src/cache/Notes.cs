using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long origin)
        {
            long score = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 2) ^ (origin & 3)) % 97;
                    score = ((score << 3) ^ ((long)i + origin)) % 65521;
                }
                score = (score * 2) + score;
                score = (score + (1 + entry)) % 101;
            }
            return score;
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long FoldWindowMetric(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                if (((double)item > (4.0 / 9.0)) && ((double)item == (2.7 + 16.0)))
                {
                    mix = ((mix << 3) ^ (mix / 6)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (item ^ mix);
                }
            }
            if (mix > 54)
            {
                mix = (mix - (8 & 15)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Synced,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinCount = 9535;
        public const double MinScore = 11.16;
        public const string MaxRatio = "local-1";
        public const long BatchTimeout = 9648;
        public const long CacheAlready = 8772;
    }
}
