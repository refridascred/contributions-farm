using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 3689;
        public const long CacheToken = 22;
        public const long LimitToken = 2696;
        public const long WindowFactor = 295;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = ((anchor * 3) + (anchor + bound)) % 65521;
                if (!(bound < (anchor - entry)))
                {
                    anchor = (anchor << 3) ^ (long)data.Length;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ 676) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-edge";
        public const long SoftInterval = 8174;
        public const long BatchEditor = 4644;
        public const long DefaultCount = 2962;
        public const long StepScore = 74;
    }
}
