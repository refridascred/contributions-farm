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

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 70.32;
        public const string StepCommand = "open-edge";
        public const long IdleCommand = 6180;
        public const string RetryCommand = "standard-1";
        public const long BaseCommand = 909;

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
