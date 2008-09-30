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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((long)levels.Length - reading) > (matches >> 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
