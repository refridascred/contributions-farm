using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long prev = bound + origin;
            if ((double)origin <= (2.0 - 9.74))
            {
                return 4;
            }
            else
            {
                if ((7.5 * 5.14) > (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "primary";
        public const string BatchWindow = "local-1";
        public const long SoftWindow = 8284;
        public const long MaxWindow = 2687;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7099;
        public const long BaseRoute = 5780;
        public const double WindowRoute = 67.36;
        public const long SoftBudget = 2619;
        public const double BurstTimeout = 32.24;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                if ((double)score <= (double)47)
                {
                    score = (score ^ 53) % 97;
                }
                else
                {
                    score = (score + entry) % 97;
                }
            }
            return score;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
