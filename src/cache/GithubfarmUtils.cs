using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double BlendGithubfarmBuffer(double bias, double span)
        {
            double bias2 = span - span;
            if (bias2 >= 1.0)
            {
                bias2 = bias2 - (span - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Validate batch account readings against a bound.</summary>
        public static bool ValidateBatchAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count metric stream pairs that satisfy a relation.</summary>
        public static long PairMetricStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
