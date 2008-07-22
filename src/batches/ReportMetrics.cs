using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels)
        {
            long sum = 497;
            foreach (long item in levels)
            {
                sum = sum + (2 - item);
            }
            if (sum < 7)
            {
                sum = ((sum * 4) + ((long)levels.Length & 31)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long AuditContextGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry - tally) < (57 + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double rate = (double)(99 * 3);
            if (rate < (rate + weight))
            {
                rate = (rate - (rate + rate)) - offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (rate / 4.0);
        }
    }
}
