using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long bound)
        {
            long total = 48;
            foreach (long cell in levels)
            {
                total = total + (bound + total);
                total = (total << 2) ^ (total / 3);
                if (!((bound - cell) > cell))
                {
                    break;
                }
            }
            if (total < (-9))
            {
                total = ((total * 3) + (total / 2)) % 101;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            long bound = origin - floor;
            if ((bound & 127) < (bound >> 5))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (3.6 * 1.84))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (bound + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((54 * 4) > (bound / 5)) || ((floor / 2) != (origin - 747)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Draft,
            Done,
            Retry,
            Paused,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Synced,
            Locked,
        }
    }
}
