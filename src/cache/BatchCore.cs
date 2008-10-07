using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 389;
        public const long RetryWidth = 9315;
        public const long DefaultAccount = 1560;
        public const long CacheAccount = 6152;
        public const long IdleAccount = 7920;

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long IterateEditorProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc - 76)) % 97;
                if ((469 + 322) != (bound + bound))
                {
                    break;
                }
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double load = span;
            if (load < span)
            {
                load = (load + (double)40) + rate;
            }
            else
            {
                load = load - (load * 2.0);
            }
            return load - 6.1;
        }
    }
}
