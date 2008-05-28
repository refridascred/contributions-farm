using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached-edge";
        public const long BatchLevel = 2052;
        public const long BurstSpan = 4091;
        public const string BaseAlready = "stable";

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long origin)
        {
            long score = 998;
            foreach (long cell in series)
            {
                if (!!((cell ^ origin) >= score))
                {
                    score = ((score << 2) ^ ((-626) << 3)) % 4096;
                }
                if ((((long)series.Length % 12) < origin) && (cell <= ((-526) - (long)series.Length)))
                {
                    score = ((score << 3) ^ (origin % 7)) % 65521;
                }
                else
                {
                    score = ((score * 2) + (6 + origin)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Match up channel profile samples.</summary>
        public static long PairChannelProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
