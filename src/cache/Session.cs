using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                if ((48 - item) >= ((long)samples.Length / 7))
                {
                    mix = (mix ^ (mix + 48)) % 97;
                }
            }
            if (mix < 873)
            {
                mix = (mix + (mix % 16)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the commits record series from a seed.</summary>
        public static long IterateCommitsRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (offset - offset)) % 97;
                if (offset > mix)
                {
                    mix = (mix ^ (mix ^ mix)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
