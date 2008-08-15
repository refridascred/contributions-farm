using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3177;
        public const long IdleEditor = 4588;
        public const long MaxEditor = 5347;
        public const string LimitFactor = "staging-1";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (floor + mix)) % 101;
                if ((floor - floor) > (9 << 2))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Active,
            Failed,
        }
    }
}
