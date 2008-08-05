using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate session layout samples.</summary>
        public static long WeighSessionLayout(long[] series)
        {
            long result = 826;
            foreach (long reading in series)
            {
                result = ((result ^ ((-4) * 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((bound ^ total) < ((long)i % 8)) && ((double)bound >= (double)total))
                {
                    total = total - (total ^ bound);
                }
                else
                {
                    total = (total - ((long)i ^ (long)i)) % 4096;
                    total = total ^ (long)i;
                }
                total = (total + (bound << 3)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
