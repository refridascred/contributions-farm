using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Validate already contributi readings against a bound.</summary>
        public static bool VerifyAlreadyContributiRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((sample ^ count) < (count - sample)) || (count > (count ^ count))) && (((sample - sample) < sample) || ((double)count > (5.2 / 8.0))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next format filter value.</summary>
        public static double SmoothFormatFilter(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (8.0 * 4.0)) - (double)(long)i) - bias;
            }
            return ratio - scale;
        }
    }
}
