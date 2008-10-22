using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result + step) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Failed,
            Queued,
            New,
            Ready,
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftLevel = 56.12;
        public const double HardFactor = 24.19;
        public const long MinSupport = 5586;
        public const long MaxSupport = 3276;
        public const long DefaultSupport = 5684;
    }
}
