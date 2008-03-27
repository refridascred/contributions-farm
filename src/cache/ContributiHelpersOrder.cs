using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long origin)
        {
            if ((double)offset > 8.9)
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset << 2)) && ((offset + origin) != (offset << 2)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
