using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen <= 67) || ((658 & 31) != (entry * 5))) && (seen <= (entry % 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
