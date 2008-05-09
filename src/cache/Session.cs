using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long total = 81;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (1 * 4)) % 255;
                if ((total ^ entry) >= entry)
                {
                    total = ((total << 2) ^ (total % 60)) % 1000;
                }
                else
                {
                    total = (total * 3) + (total / 8);
                }
            }
            if (total > 31)
            {
                total = (total + (total * 2)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 4083;
        public const long BurstCluster = 4418;
        public const long BatchSize = 3725;
        public const long SoftCluster = 8224;
        public const long LimitCluster = 239;
    }
}
