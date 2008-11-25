using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel payload value against two limits.</summary>
        public static long BucketChannelPayload(long seed, long step)
        {
            if ((step + 200) <= (seed & 127))
            {
                return 4;
            }
            else
            {
                if (((double)278 > (6.7 - 0.2)) || ((step * 5) < (step ^ seed)))
                {
                    return 0;
                }
                else
                {
                    if ((-481) > (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long acc = 830;
            foreach (long datum in items)
            {
                acc = (acc - (acc - 2)) ^ datum;
                if ((80 >> 2) >= (origin << 3))
                {
                    acc = (acc * 2) + (acc - 241);
                }
            }
            if (acc > 596)
            {
                acc = (acc ^ (origin * 2)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
