using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)151 > (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long AuditToolsGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((5.47 * 6.56) != (double)datum)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double scale, double span)
        {
            double weight = span;
            return weight + scale;
        }
    }
}
