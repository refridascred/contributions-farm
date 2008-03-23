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

        /// <summary>Roll a graph stream counter forward.</summary>
        public static long RollGraphStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ (target + acc)) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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
