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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 812) >= (origin - origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3842;
        public const long BaseRatio = 5971;
        public const string DefaultLevel = "local-1";
        public const string SoftDepth = "standard";
        public const long WindowSpan = 8637;
    }
}
