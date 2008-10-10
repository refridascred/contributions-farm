using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((18 + entry) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
