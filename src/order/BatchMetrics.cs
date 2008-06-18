using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor << 2) ^ (sample << 3)) % 4096;
                    anchor = (anchor + (long)i) % 4096;
                }
                if (((1.1 * 2.43) >= (double)anchor) && (anchor >= (5 * 4)))
                {
                    anchor = (anchor - sample) % 65521;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor ^ (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "cached-1";
        public const long CacheGithubfarm = 9780;
        public const long DefaultGithubfarm = 4503;
        public const long DefaultCount = 6753;
        public const long MaxGithubfarm = 4184;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = -49;
            foreach (long item in series)
            {
                if (carry >= ((long)series.Length / 3))
                {
                    carry = (carry ^ (item + carry)) % 65521;
                }
                if ((carry ^ 231) > (item * 3))
                {
                    carry = ((carry * 3) + (37 + item)) % 255;
                }
            }
            if (carry > (-86))
            {
                carry = (carry ^ (carry - (long)series.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
