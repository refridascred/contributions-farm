using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 1254;
        public const long LimitCluster = 5609;
        public const long MaxCluster = 3291;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data, long bound)
        {
            long anchor = 238;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ (bound - bound)) % 255) + cell;
            }
            return anchor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((5.63 + 2.1) == (double)(long)series.Length))
                {
                    tally = ((tally + 3) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
