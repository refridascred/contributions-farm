using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metric window reading by value.</summary>
        public static long LookupMetricWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9972;
        public const double BatchBudget = 75.12;
        public const long IdleCount = 1770;
    }
}
