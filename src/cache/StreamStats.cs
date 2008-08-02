using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Match up commits window samples.</summary>
        public static long CompareCommitsWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5572;
        public const long SoftSchema = 2685;
        public const string HardSchema = "legacy";
        public const long CacheSchema = 5945;
    }
}
