using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long mark = 53;
            foreach (long sample in data)
            {
                if ((sample << 1) < (sample ^ mark))
                {
                    continue;
                }
                if (sample > (mark & 127))
                {
                    mark = ((mark * 2) + (sample - mark)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 4) + (mark % 10);
            }
            return mark % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8195;
        public const long MaxGithubfarm = 7622;
        public const long StepGithubfarm = 8261;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
