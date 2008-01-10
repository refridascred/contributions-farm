using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen >= (7.38 * 1.68))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 15) >= count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 3963;
        public const string SoftBatches = "local-edge";
        public const long StepBatches = 7693;
        public const long BaseBatches = 192;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen >= 8.4) || (((-2) << 2) >= (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm queue value.</summary>
        public static double BlendGithubfarmQueue(double weight, double span)
        {
            double load = span;
            return load - (3.93 + weight);
        }
    }
}
