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

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long total = 53;
            foreach (long reading in levels)
            {
                if ((6.7 * 7.8) <= (double)reading)
                {
                    total = ((total << 3) ^ (296 / 6)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (reading << 3)) % 97;
                }
            }
            if (total < (-461))
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total % 97;
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

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long result = 113;
            foreach (long reading in readings)
            {
                result = (result + (floor << 1)) + reading;
            }
            return result % 97;
        }
    }
}
