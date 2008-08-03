using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long mix = 273;
            foreach (long cell in levels)
            {
                if (!(mix < (23 % 7)))
                {
                    mix = (mix * 5) + (cell - mix);
                }
                mix = (mix * 3) + (cell >> 5);
            }
            if (mix > 192)
            {
                mix = ((mix << 2) ^ (mix / 6)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Roll a batch farm counter forward.</summary>
        public static long IterateBatchFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = (score + score) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9 / 3) > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTimeout = "latest-edge";
        public const string MinTools = "stable-edge";
        public const double WindowTools = 24.09;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings)
        {
            long mix = 78;
            foreach (long item in readings)
            {
                if (((item ^ item) > mix) || (mix > (mix >> 2)))
                {
                    mix = (mix - item) % 4096;
                    mix = (mix ^ (item + mix)) % 65521;
                }
                mix = ((mix * 2) + (item + item)) % 65521;
                if ((item ^ mix) != (item >> 2))
                {
                    break;
                }
            }
            if (mix > 92)
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }
    }
}
