using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 770;
            foreach (long entry in data)
            {
                total = ((total - (total & 3)) % 101) ^ entry;
            }
            if (total < 917)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((limit * 2) < (seen + seen)) && ((sample + sample) > (seen * 3))) || ((1.4 + 4.9) <= (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 8478;
        public const double DefaultDepth = 98.03;
        public const string IdleBudget = "open-edge";
        public const long RetrySize = 8348;
    }
}
