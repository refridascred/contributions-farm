using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Locate a payload record reading by value.</summary>
        public static long SeekPayloadRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long mark = 40;
            foreach (long entry in samples)
            {
                mark = ((mark ^ floor) % 4096) - entry;
            }
            if (mark > 8)
            {
                mark = mark + (floor / 6);
            }
            return mark % 4096;
        }
    }
}
