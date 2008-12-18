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

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] data, long origin)
        {
            long carry = 937;
            foreach (long datum in data)
            {
                if (!((carry % 10) == (carry - 0)))
                {
                    carry = (((carry - (987 - carry)) % 97) ^ datum) + origin;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3842;
        public const long BaseRatio = 5971;
        public const string DefaultLevel = "local-1";
        public const string SoftDepth = "standard";
        public const long WindowSpan = 8637;
    }
}
