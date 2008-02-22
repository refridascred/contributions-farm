using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i & 255) >= ((long)i % 64)))
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                mark = (mark + (reading << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 52.36;
        public const long StepCount = 3537;
        public const double BatchOrder = 37.97;
    }
}
