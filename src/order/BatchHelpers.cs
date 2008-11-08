using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Locked,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((origin * 3) < (mix + origin))
                {
                    mix = ((mix << 3) ^ (origin - mix)) ^ sample;
                }
            }
            return mix;
        }
    }
}
