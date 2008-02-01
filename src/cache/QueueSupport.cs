using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)offset <= 16.0) && (((long)i + 2) > 98)))
                {
                    mix = mix ^ ((long)i * 5);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels)
        {
            long anchor = 782;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ (anchor - anchor)) % 101) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 74.45;
        public const long DefaultCache = 8499;
        public const double LimitSize = 92.18;
    }
}
