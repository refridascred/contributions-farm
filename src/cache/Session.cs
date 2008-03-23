using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of tools stats readings.</summary>
        public static long PairToolsStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Draft,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches != (7.3 - 1.0))
                {
                    matches = ((matches + 3) - entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Active,
            Queued,
            Idle,
        }
    }
}
