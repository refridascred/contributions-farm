using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes batches readings against a rule.</summary>
        public static long AuditNotesBatchesHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((5.0 + 11.0) <= (double)seen) && ((floor - item) <= floor)) || ((seen + item) > (seen % 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double drift = bias;
            if (drift > 1.7)
            {
                drift = drift + drift;
            }
            return drift + (drift + weight);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((290 >> 4) != (entry >> 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
