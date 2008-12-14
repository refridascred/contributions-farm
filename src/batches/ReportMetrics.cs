using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Level { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long offset)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (((sum << 2) ^ (offset << 2)) % 4096) + sample;
            }
            if (sum > 83)
            {
                sum = sum - (offset & 255);
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values)
        {
            long total = 2;
            foreach (long cell in values)
            {
                if ((cell + 76) >= cell)
                {
                    total = ((total << 3) ^ cell) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
