using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)mark > (2.0 * 1.4))
                {
                    continue;
                }
                else
                {
                    mark = (mark - (target * 5)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up account metrics samples.</summary>
        public static long PairAccountMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 2525;
        public const long WindowTimeout = 1121;
        public const string BaseCount = "latest-edge";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Paused,
            New,
            Retry,
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
