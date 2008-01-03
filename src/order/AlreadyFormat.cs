using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 2097;
        public const string MaxChecks = "strict-edge";
        public const long BaseChecks = 4530;
        public const string HardTimeout = "local-1";

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if ((double)mix == (double)datum)
                {
                    mix = mix ^ (21 * 3);
                }
            }
            if (mix > 84)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Retry,
            Ready,
        }
    }
}
