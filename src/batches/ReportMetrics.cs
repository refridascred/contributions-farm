using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long SortChannelRecord(long bound, long floor)
        {
            if ((160 - bound) >= (floor / 7))
            {
                return 2;
            }
            else
            {
                if (bound >= (289 / 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
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
