using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Failed,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "open-edge";
        public const string RetryLevel = "fallback-1";
        public const long SoftFactor = 6055;
        public const string RetrySession = "latest-edge";

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double ProjectAccountGithubfarm(double bias, double floor)
        {
            double rate = floor + bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 19.0) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (double)total)
                {
                    total = (total - ((long)values.Length % 97)) % 101;
                }
                else
                {
                    total = total ^ datum;
                }
                if (((datum / 5) == ((-297) + datum)) || ((double)total > (double)datum))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total * 3) + (total << 2);
            }
            return total;
        }
    }
}
