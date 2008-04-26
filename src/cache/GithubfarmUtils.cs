using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long bound, long bound2)
        {
            if (5.1 > (double)bound2)
            {
                return 4;
            }
            else
            {
                if ((bound - bound) != (bound % 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 <= (7.0 * 8.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= (bound2 * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
