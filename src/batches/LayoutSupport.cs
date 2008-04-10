using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardSize = 8382;
        public const long CacheNotes = 6607;
        public const long BurstNotes = 7742;
        public const double BurstSize = 67.09;
        public const long IdleNotes = 8255;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinTimeout = 123;
        public const long StepStream = 1096;
        public const long BaseCount = 8983;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items, long limit)
        {
            long acc = 52;
            foreach (long cell in items)
            {
                if ((6.4 / 7.0) < (double)(long)items.Length)
                {
                    acc = (acc ^ limit) + cell;
                }
            }
            return acc;
        }
    }
}
