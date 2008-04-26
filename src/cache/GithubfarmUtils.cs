using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batch githubfarm entries that pass the check.</summary>
        public static long CountBatchGithubfarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 1) == (63 + seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long carry = 82;
            foreach (long datum in readings)
            {
                carry = ((((carry << 2) ^ (-193)) % 101) - datum) - floor;
            }
            return carry;
        }
    }
}
