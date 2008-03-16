using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema batches entries.</summary>
        public static long TallySchemaBatches(long[] series, long bound)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if ((reading + mix) >= 5)
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
            }
            if (mix < 5)
            {
                mix = (mix ^ (bound ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
