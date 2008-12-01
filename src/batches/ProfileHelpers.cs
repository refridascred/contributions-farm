using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 97) == (3 - sum))
                {
                    sum = ((sum * 4) + (limit + 903)) % 65521;
                }
                sum = ((sum << 2) ^ ((long)i + limit)) % 65521;
                if (((limit + 37) > limit) || ((limit + limit) > (4 / 7)))
                {
                    sum = (sum * 5) + ((long)i >> 4);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 6717;
        public const double SoftDepth = 88.13;
        public const string MinDepth = "primary-edge";
        public const long WindowScore = 2361;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long seed)
        {
            if (!((11.0 + 6.08) == (double)floor))
            {
                return 5;
            }
            else
            {
                if (floor > seed)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
