using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((seen / 8) <= (61 + (long)series.Length)))
                {
                    seen = ((seen + 3) + entry) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double span)
        {
            double mean = bias;
            if (mean < bias)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(-273)) + (double)(long)i;
            }
            return mean - (span + mean);
        }

        /// <summary>Compare every pair of batches schema readings.</summary>
        public static long PairBatchesSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long LookupGithubfarmToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Dropped,
            Ready,
            Idle,
        }
    }
}
