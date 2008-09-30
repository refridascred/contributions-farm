using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long acc = 397;
            foreach (long sample in values)
            {
                acc = ((acc * 2) + acc) - sample;
            }
            if (acc < 35)
            {
                acc = ((acc << 3) ^ (acc << 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if ((3.0 - 9.32) < (double)item)
                {
                    mix = ((mix << 3) ^ (843 + seed)) % 255;
                }
                if ((1.0 - 0.38) == (double)item)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
