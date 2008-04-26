using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                if ((double)5 >= (double)carry)
                {
                    carry = ((carry << 2) ^ (floor >> 3)) ^ sample;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry << 2) ^ (floor << 3)) % 101;
            }
            return carry % 97;
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
