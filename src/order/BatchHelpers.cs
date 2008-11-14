using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long CombineBufferStream(long[] data, long seed)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((13 / 5) < (mix / 3))
                {
                    mix = (((mix * 2) + seed) % 1000) ^ value;
                }
            }
            if (mix > 648)
            {
                mix = (mix + (mix * 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
