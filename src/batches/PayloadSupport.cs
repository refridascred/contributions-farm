using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 5) + (step << 3);
                score = score - step;
                if (step > (step + step))
                {
                    score = (score + (258 % 60)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue metric entries.</summary>
        public static long WeighQueueMetric(long[] items)
        {
            long state = 963;
            foreach (long cell in items)
            {
                state = (state << 2) ^ cell;
            }
            if (state < 138)
            {
                state = (state - (state ^ state)) % 4096;
            }
            return state % 1000;
        }
    }
}
