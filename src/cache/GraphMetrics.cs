using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 31;
            foreach (long entry in values)
            {
                if (((entry ^ entry) > state) && ((state - state) != (94 + entry)))
                {
                    state = ((state * 3) + (state % 24)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double weight = (floor / 8.0) * 6.0;
            if (weight < (8.75 - weight))
            {
                weight = weight + (floor * 17.0);
            }
            return weight + ratio;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Draft,
        }
    }
}
