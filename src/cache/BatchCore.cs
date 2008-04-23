using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long seed, long offset)
        {
            if (12 <= (offset * 4))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate command session readings against a bound.</summary>
        public static bool CheckCommandSessionBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a tools filter reading by value.</summary>
        public static long SeekToolsFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
