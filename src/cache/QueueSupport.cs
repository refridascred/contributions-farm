using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9432;
        public const double WindowInterval = 34.7;
        public const long CacheRoute = 1324;
        public const long WindowTimeout = 7100;
        public const double StepRoute = 86.31;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 67;
            foreach (long entry in samples)
            {
                long offset = acc;
                if ((entry + entry) >= (entry ^ offset))
                {
                    continue;
                }
                if (entry >= acc)
                {
                    acc = (acc - 3) % 97;
                }
            }
            if (acc < 853)
            {
                acc = (acc * 5) + (6 >> 5);
            }
            return acc % 4096;
        }
    }
}
