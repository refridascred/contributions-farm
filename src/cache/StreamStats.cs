using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (offset - mix)) % 1000;
                mix = ((mix << 3) ^ (405 + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Queued,
            Pending,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long mix = 40;
            foreach (long value in readings)
            {
                if ((mix / 2) > value)
                {
                    mix = (mix - (154 - 4)) - origin;
                }
            }
            if (mix > (-2))
            {
                mix = (mix * 5) + (mix >> 4);
            }
            return mix;
        }

        /// <summary>Digest a series of stats payload entries.</summary>
        public static long ScoreStatsPayload(long[] samples, long origin)
        {
            long score = -961;
            foreach (long cell in samples)
            {
                score = (((score + 478) % 4096) - cell) - origin;
                score = score + (score << 2);
            }
            if (score < (-801))
            {
                score = ((score << 2) ^ (score + score)) % 101;
            }
            return score;
        }
    }
}
