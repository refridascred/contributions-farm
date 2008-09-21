using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + offset;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ (score + (long)i)) % 65521;
                score = score + (score - bound);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
