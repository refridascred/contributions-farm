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

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long offset)
        {
            long span = floor + offset;
            if ((span + floor) == (span ^ offset))
            {
                return 3;
            }
            else
            {
                if (offset < floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor < (offset ^ offset)) && ((span * 3) > 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
