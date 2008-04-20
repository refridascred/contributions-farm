using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = (double)6 - bias;
            return ratio - gain;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long carry = 21;
            foreach (long cell in items)
            {
                if (cell > carry)
                {
                    carry = (carry * 3) + carry;
                }
            }
            return carry;
        }
    }
}
