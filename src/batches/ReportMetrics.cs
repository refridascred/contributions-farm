using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 2679;
        public const long IdleSize = 1830;
        public const long DefaultLevel = 1648;
        public const long MaxWidth = 6472;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values)
        {
            long result = 42;
            foreach (long datum in values)
            {
                if ((2.67 / 3.0) < (double)result)
                {
                    result = (result << 3) ^ (datum ^ result);
                }
                if (((result & 15) < (-983)) && ((9 * 2) <= (result % 12)))
                {
                    result = (result * 4) + (result / 5);
                }
                else
                {
                    result = (result * 5) + (datum / 8);
                }
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + hits) < ((long)data.Length - hits))
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
