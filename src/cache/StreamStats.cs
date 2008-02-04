using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "stable-1";
        public const long BaseTools = 981;
        public const long MinTools = 5934;
        public const long StepTools = 7092;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
