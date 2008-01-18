using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - count) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 13.94;
        public const long BaseFactor = 4186;
        public const double IdleScore = 71.56;
        public const string RetryRatio = "standard-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxInterval = 50.17;
        public const double HardReport = 2.7;
        public const long MinScore = 9179;
        public const long MaxWidth = 9419;
    }
}
