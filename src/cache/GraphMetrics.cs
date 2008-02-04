using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next report stream value.</summary>
        public static double BlendReportStream(double weight, double span)
        {
            double ratio = 20.0;
            if (ratio < (ratio - span))
            {
                ratio = (ratio + ratio) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span / 3.0)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((limit <= (15 + limit)) && (77 <= (count / 2))) && (item > (limit + 582)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                long bound = (score ^ limit) & 7;
                score = (score - bound) % 101;
                score = ((score * 5) + bound) % 97;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
