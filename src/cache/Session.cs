using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Stale,
            Active,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long AuditTokenToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading % 24) >= (reading & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
