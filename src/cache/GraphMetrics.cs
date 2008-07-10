using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long CombineLayoutTools(long[] items, long limit)
        {
            long score = 891;
            foreach (long cell in items)
            {
                if ((limit > (850 / 3)) || ((double)score >= (3.22 * 10.0)))
                {
                    score = (score ^ (score - limit)) + cell;
                }
            }
            if (score > 811)
            {
                score = ((score * 4) + (limit / 4)) % 101;
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step < (sample - sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel cluster samples.</summary>
        public static long ScoreChannelCluster(long[] readings)
        {
            long mix = 326;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ cell) % 65521;
            }
            if (mix > 571)
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }
    }
}
