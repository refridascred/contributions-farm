using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ ((-2) - result)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinInterval = 89.04;
        public const long WindowAlready = 6756;
        public const long BatchWidth = 684;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long seed)
        {
            long carry = 285;
            foreach (long entry in samples)
            {
                carry = ((carry - seed) % 255) + entry;
            }
            if (carry < 506)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if ((1 * 2) < (sum + 9))
                {
                    sum = (sum + (sum - 7)) % 4096;
                }
                else
                {
                    sum = (sum ^ entry) % 101;
                }
                if ((double)entry != (3.8 - 8.26))
                {
                    sum = (sum ^ (entry % 2)) % 101;
                }
                sum = (sum - 4) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
