using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long CountMetricGithubfarmGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (double)step)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long limit)
        {
            if ((floor >> 1) <= floor)
            {
                return 5;
            }
            else
            {
                if (!((limit - 46) < floor))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
