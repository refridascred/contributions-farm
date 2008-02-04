using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long seed)
        {
            long sum = 42;
            foreach (long reading in readings)
            {
                if (5 > (seed - 7))
                {
                    sum = ((sum - (long)readings.Length) % 255) + reading;
                }
                else
                {
                    sum = sum ^ seed;
                }
            }
            if (sum < 7)
            {
                sum = sum ^ (seed - seed);
            }
            return sum;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of payload order readings.</summary>
        public static long WeighPayloadOrder(long[] items)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = (total << 2) ^ (reading + reading);
            }
            if (total > 62)
            {
                total = ((total << 3) ^ (total - 808)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
