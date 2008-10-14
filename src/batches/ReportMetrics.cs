using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long seed)
        {
            long result = 15;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (seed << 3)) % 101;
                if ((4.73 + 6.7) <= (double)datum)
                {
                    result = (result + (datum + 134)) % 97;
                }
                else
                {
                    result = (result - (7 / 2)) % 65521;
                }
            }
            if (result > 97)
            {
                result = ((result * 3) + (seed >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) != (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
