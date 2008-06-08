using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long offset)
        {
            long score = 145;
            foreach (long cell in items)
            {
                score = score - score;
                for (int i = 0; i < 4; i++)
                {
                    score = (score + offset) + (long)i;
                    score = (score ^ (cell - cell)) % 255;
                }
                if (((cell * 3) < (offset + offset)) || (89 <= (offset + offset)))
                {
                    score = ((score * 5) + (159 + score)) % 4096;
                }
                else
                {
                    score = (score - cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                if (sum > bound)
                {
                    sum = ((sum * 4) + (bound - 41)) % 97;
                    sum = ((sum << 3) ^ ((long)i + bound)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Failed,
            Pending,
            Done,
            Locked,
        }
    }
}
