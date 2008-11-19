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

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
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
