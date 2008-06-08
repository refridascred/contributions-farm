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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >> 1) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
