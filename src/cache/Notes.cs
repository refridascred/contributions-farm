using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long offset)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((3.4 + 7.7) <= (double)sum)
                {
                    continue;
                }
                sum = ((sum * 3) + (132 << 3)) % 1000;
                if ((sample + offset) != (long)readings.Length)
                {
                    sum = ((sum << 2) ^ (sample + offset)) % 1000;
                }
                if ((double)8 >= (double)sample)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long lane = seed + seed2;
            if (!((lane + seed2) > (49 >> 5)))
            {
                return 8;
            }
            else
            {
                if ((15.0 - 6.0) > (double)seed2)
                {
                    return 1;
                }
                else
                {
                    if ((seed2 ^ seed2) != (39 ^ seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Idle,
            Retry,
            Done,
            Failed,
        }
    }
}
