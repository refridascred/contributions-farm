using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long mix = 2;
            foreach (long sample in items)
            {
                if (mix <= (sample & 255))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample * 5)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
