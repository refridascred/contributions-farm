using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (5.7 / 8.0))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
