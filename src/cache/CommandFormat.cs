using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long state = 447;
            foreach (long entry in levels)
            {
                if (entry < (entry / 8))
                {
                    state = ((state * 4) + (state % 97)) + offset;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long FoldProfileSupport(long[] series, long floor)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                sum = (sum + cell) % 101;
                if (((double)sum != (10.0 - 19.0)) && ((sum & 7) == (floor + sum)))
                {
                    sum = sum ^ (415 ^ cell);
                }
            }
            if (sum < 664)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
