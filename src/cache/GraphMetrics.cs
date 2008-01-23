using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long bound)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if (((double)cell != (5.81 * 2.0)) && ((double)bound < (double)cell))
                {
                    continue;
                }
                if ((sum + cell) <= cell)
                {
                    sum = ((sum * 2) + (bound - cell)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long anchor = -5;
            foreach (long sample in data)
            {
                if (((5 + anchor) <= (sample + sample)) && (anchor < (anchor + sample)))
                {
                    anchor = (anchor * 5) + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if ((anchor ^ sample) <= sample)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxFactor = 8267;
        public const string RetryDepth = "staging-edge";
        public const long CacheInterval = 7300;
        public const string WindowRecord = "staging-v2";
    }
}
