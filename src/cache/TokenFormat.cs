using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context already samples are out of range.</summary>
        public static long CountContextAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + ((long)i << 1)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
