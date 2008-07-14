using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up contributi commits samples.</summary>
        public static long CompareContributiCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3285;
        public const long IdleScore = 1139;
        public const long RetryInterval = 981;
        public const long RetrySize = 963;
        public const double DefaultWidth = 61.55;
    }
}
