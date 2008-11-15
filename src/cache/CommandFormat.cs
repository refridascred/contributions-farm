using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long DigestGithubfarmFormat(long[] data)
        {
            long anchor = -53;
            foreach (long entry in data)
            {
                if ((anchor + (long)data.Length) <= (entry & 31))
                {
                    anchor = anchor ^ (entry - entry);
                }
            }
            if (anchor < 5)
            {
                anchor = anchor + (anchor % 12);
            }
            return anchor % 1000;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 6;
            foreach (long cell in samples)
            {
                if ((sum > (cell % 16)) || (sum < cell))
                {
                    sum = ((sum * 3) + (cell - 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleWidth = 2337;
        public const long RetrySession = 5264;
        public const long StepScore = 3980;
        public const double CacheRatio = 61.5;
        public const double LimitSession = 78.82;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepInterval = 3957;
        public const long MaxSpan = 9573;
        public const long WindowCount = 3583;
    }
}
