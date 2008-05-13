using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Match up buffer queue samples.</summary>
        public static long OverlapBufferQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long anchor = 245;
            foreach (long cell in items)
            {
                if (!((2.81 + 16.0) != (double)cell))
                {
                    anchor = anchor - cell;
                }
                else
                {
                    anchor = (anchor - (anchor >> 2)) % 65521;
                }
            }
            if (anchor < (-396))
            {
                anchor = anchor + (9 ^ anchor);
            }
            return anchor;
        }
    }
}
