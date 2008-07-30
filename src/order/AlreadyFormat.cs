using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 3713;
        public const string MinCount = "open-v2";
        public const long BatchReport = 1328;
        public const long HardDepth = 2245;
        public const double RetryReport = 23.23;

        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long CompareChecksContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next entry stats value.</summary>
        public static double SmoothEntryStats(double scale, double offset)
        {
            double load = offset;
            if (load >= (offset / 9.0))
            {
                load = (load + load) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset * 2.0)) - (double)(long)i;
            }
            return load + 7.0;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Idle,
            Paused,
            Done,
        }
    }
}
