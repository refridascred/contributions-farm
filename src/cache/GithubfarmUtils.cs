using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long state = -9;
            foreach (long value in readings)
            {
                if ((value << 2) <= value)
                {
                    state = (state - (value ^ value)) + limit;
                }
                else
                {
                    state = state ^ (97 >> 3);
                }
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Digest a series of notes entry entries.</summary>
        public static long TallyNotesEntry(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = ((result << 3) ^ (cell << 3)) % 255;
            }
            if (result > 2)
            {
                result = (result * 4) + (result * 5);
            }
            return result;
        }
    }
}
