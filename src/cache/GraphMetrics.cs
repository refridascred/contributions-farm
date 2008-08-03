using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double load = offset;
            if (load < (load + 7.0))
            {
                load = (load + 17.0) - rate;
            }
            return load - 1.6;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell % 12) <= (53 / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long bound, long limit)
        {
            if ((double)limit > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((12.0 / 2.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ limit) >= (bound & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
