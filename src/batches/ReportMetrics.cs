using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (offset - offset)) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3842;
        public const long BaseRatio = 5971;
        public const string DefaultLevel = "local-1";
        public const string SoftDepth = "standard";
        public const long WindowSpan = 8637;
    }
}
