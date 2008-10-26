using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)count >= 8.77))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Count context buffer pairs that satisfy a relation.</summary>
        public static long CompareContextBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9178;
        public const double BaseScore = 59.71;
        public const string HardAccount = "strict-v2";
        public const long DefaultAccount = 7950;
        public const double IdleAccount = 62.36;
    }
}
