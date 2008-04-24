using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long bound)
        {
            if (!((58 * 4) == (bound ^ 843)))
            {
                return 8;
            }
            else
            {
                if (6.8 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a buffer channel reading by value.</summary>
        public static long LocateBufferChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
