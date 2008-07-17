using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up graph checks samples.</summary>
        public static long CompareGraphChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
