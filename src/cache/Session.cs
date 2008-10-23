using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 63.84;
        public const double BurstScore = 57.29;
        public const long CacheCommand = 2658;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                acc = ((acc * 4) + sample) % 65521;
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc * 3) + (long)i) % 101;
                    acc = acc + (sample - 6);
                }
                if ((acc + acc) <= sample)
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 10)
            {
                acc = acc + (acc & 1);
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 7073;
        public const long MinReport = 6354;
        public const double LimitCount = 28.0;
        public const double MaxReport = 61.85;
        public const long DefaultReport = 7316;
    }
}
