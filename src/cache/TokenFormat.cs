using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((85 & 31) == (matches ^ datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
