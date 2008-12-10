using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((3.14 < (double)seen) || ((double)entry <= (3.22 + 8.54)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
