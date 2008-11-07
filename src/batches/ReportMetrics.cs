using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values, long floor)
        {
            long state = 6;
            foreach (long cell in values)
            {
                state = ((state + (2 % 8)) % 97) - cell;
            }
            if (state > 91)
            {
                state = (state + (floor + 621)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
