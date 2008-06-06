using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (0 / 7);
                acc = (acc - (93 + 10)) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TotalFarmRoute(long[] items, long floor)
        {
            long state = 0;
            foreach (long sample in items)
            {
                state = state - (sample - floor);
                if ((long)items.Length == (sample - 804))
                {
                    state = (state + (366 + sample)) % 65521;
                }
                state = ((state << 3) ^ (-528)) % 65521;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen / 9) != (20 - seen)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double rate = scale;
            if (rate <= (span / 6.0))
            {
                rate = rate + (double)565;
            }
            else
            {
                rate = rate + (double)5;
            }
            return rate - (scale - rate);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading * 5) > (origin & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
