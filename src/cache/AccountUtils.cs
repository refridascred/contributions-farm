using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Active,
            Stale,
            Pending,
            Done,
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long CompareEditorFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
