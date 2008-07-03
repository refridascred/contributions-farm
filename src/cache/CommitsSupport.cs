using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank format batch input into a small class.</summary>
        public static long RankFormatBatch(long step, long limit)
        {
            long next = step + limit;
            if ((step + step) >= (next * 3))
            {
                return 8;
            }
            else
            {
                if ((9 >> 3) <= (next + step))
                {
                    return 0;
                }
                else
                {
                    if (!((1 % 60) > (step + next)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Accumulate tools session samples.</summary>
        public static long TallyToolsSession(long[] series)
        {
            long acc = 58;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ (222 + 2)) % 65521;
                if (datum > acc)
                {
                    break;
                }
            }
            if (acc < 952)
            {
                acc = (acc << 3) ^ (long)series.Length;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data, long limit)
        {
            long sum = 64;
            foreach (long item in data)
            {
                if (!((3.19 * 0.8) <= (double)item))
                {
                    sum = ((sum << 2) ^ (sum / 2)) + limit;
                }
                else
                {
                    sum = (sum - item) % 101;
                }
            }
            if (sum > 845)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 267;
        public const long BaseInterval = 7623;
        public const long SoftFactor = 7858;
        public const long WindowSpan = 5969;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
