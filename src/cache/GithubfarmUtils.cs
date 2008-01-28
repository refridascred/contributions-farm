using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long state = 48;
            foreach (long value in samples)
            {
                if (state < (-19))
                {
                    state = (state ^ 5) ^ value;
                }
            }
            if (state < 821)
            {
                state = ((state << 2) ^ (5 << 3)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepLevel = "standard-v2";
        public const long RetryTools = 8337;
        public const double DefaultInterval = 0.8;
    }
}
