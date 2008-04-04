using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleCount = "legacy-1";
        public const string BaseTimeout = "legacy-1";
        public const string WindowQueue = "latest";
        public const long SoftRatio = 3965;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long total = 185;
            foreach (long item in samples)
            {
                total = (total ^ (floor + 81)) ^ item;
            }
            if (total < 97)
            {
                total = total ^ (floor + total);
            }
            return total % 65521;
        }
    }
}
