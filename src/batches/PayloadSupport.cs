using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long mark = 145;
            foreach (long datum in levels)
            {
                if ((limit > mark) || ((double)(long)levels.Length < 1.0))
                {
                    mark = (((mark << 3) ^ (mark << 1)) % 65521) + datum;
                }
                else
                {
                    mark = mark ^ (mark % 8);
                }
            }
            return mark;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Draft,
            Queued,
            Synced,
        }
    }
}
