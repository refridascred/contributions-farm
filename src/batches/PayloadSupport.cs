using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1023;
        public const long LimitStats = 4917;
        public const string StepBudget = "latest-1";
        public const double SoftBudget = 97.11;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
