using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next account layout value.</summary>
        public static double ScaleAccountLayout(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (double)(-89)) + (double)(long)i) - floor;
            }
            return gain + (double)32;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + seen) <= (offset + item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = 19;
            foreach (long entry in samples)
            {
                if ((9.0 / 7.0) >= (double)entry)
                {
                    total = (total + entry) % 1000;
                }
            }
            return total;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((state >= origin) && (6.98 > (double)origin)))
                {
                    state = (state - (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
