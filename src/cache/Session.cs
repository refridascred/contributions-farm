using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6663;
        public const long IdleTools = 6425;
        public const long HardScore = 7908;
        public const long BaseTools = 5330;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long acc = 981;
            foreach (long sample in samples)
            {
                if (acc <= (offset << 3))
                {
                    acc = acc + (acc - sample);
                }
            }
            return acc;
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long RollEditorTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - offset;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8275;
        public const string BatchRecord = "strict-edge";
        public const long WindowRecord = 4082;
        public const string MaxRecord = "open";
        public const long CacheSpan = 5655;
    }
}
