using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long SeekChannelEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long sum = -370;
            foreach (long reading in samples)
            {
                if ((458 > (limit - limit)) || (6 >= (sum >> 4)))
                {
                    sum = (sum - (limit ^ limit)) + reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Dropped,
            Draft,
            Failed,
            Done,
        }
    }
}
