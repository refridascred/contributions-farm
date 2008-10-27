using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(tally < (datum / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double mean = (double)(306 % 5);
            if (mean > (mean / 9.0))
            {
                mean = (mean - (8.0 * 5.98)) + span;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + rate;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
