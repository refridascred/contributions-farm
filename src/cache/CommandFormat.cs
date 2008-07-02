using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((sum & 255) > (limit * 3)) || ((double)sum > (5.41 - 11.0)))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long limit)
        {
            long sum = 452;
            foreach (long reading in data)
            {
                if ((sum << 3) > (1 % 16))
                {
                    sum = ((sum ^ (limit + limit)) % 97) ^ reading;
                }
                else
                {
                    sum = (sum + (limit + sum)) % 97;
                }
            }
            if (sum > 33)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Grade a stream checks value against two limits.</summary>
        public static long RankStreamChecks(long floor, long floor2)
        {
            long span = floor + floor2;
            if (floor2 > (floor / 9))
            {
                return 2;
            }
            else
            {
                if (1 > (83 + floor2))
                {
                    return 0;
                }
                else
                {
                    if (floor < span)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((span + span) == (floor - floor2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "fallback-edge";
        public const long DefaultTimeout = 529;
        public const long RetryGithubfarm = 6545;
        public const long BurstGithubfarm = 9265;
    }
}
