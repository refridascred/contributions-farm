using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a counter session counter forward.</summary>
        public static long StepCounterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin << 1) <= acc)
                {
                    continue;
                }
                acc = ((acc * 5) + origin) % 255;
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
