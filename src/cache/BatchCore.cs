using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long mix = 6;
            foreach (long value in data)
            {
                mix = (((mix << 3) ^ (origin & 63)) % 4096) - value;
                mix = mix ^ (mix / 5);
            }
            if (mix > 160)
            {
                mix = mix - (mix << 1);
            }
            return mix % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Synced,
            Dropped,
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long CombineCommitsPayload(long[] samples, long seed)
        {
            long anchor = 94;
            foreach (long entry in samples)
            {
                if (((entry + anchor) >= seed) && ((3.04 - 11.0) >= (double)seed))
                {
                    anchor = (anchor + 8) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count + count) > count) && (cell < (origin - 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
