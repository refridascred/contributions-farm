using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double offset)
        {
            double drift = weight * 3.6;
            if (drift > drift)
            {
                drift = (drift + (double)7) - offset;
            }
            return drift + (weight * 14.0);
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long acc = 76;
            foreach (long sample in levels)
            {
                acc = (acc ^ (387 + acc)) % 101;
                acc = acc - sample;
                acc = (acc ^ (sample + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "legacy-1";
        public const long MinDepth = 2799;
        public const double RetrySize = 68.85;

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double ratio = floor;
            return (ratio - 9.82) + bias;
        }
    }
}
