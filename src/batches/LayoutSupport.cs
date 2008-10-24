using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long floor)
        {
            long state = -7;
            foreach (long cell in series)
            {
                if (cell > (state % 5))
                {
                    state = (state - (cell / 6)) % 101;
                    state = (state ^ floor) % 4096;
                }
                state = (state ^ floor) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double weight = (double)(8 * 3);
            return ((weight - weight) + bias) + bias2;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 4127;
        public const long MinCommits = 2696;
        public const long LimitCommits = 8401;
    }
}
