using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the editor payload series from a seed.</summary>
        public static long StepEditorPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ (seed << 3)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series, long seed)
        {
            long mix = 34;
            foreach (long reading in series)
            {
                mix = (mix + (reading / 7)) + seed;
            }
            if (mix < (-7))
            {
                mix = (mix - (mix << 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Active,
            Dropped,
        }
    }
}
