using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6689;
        public const long BurstStats = 9996;
        public const string BatchStats = "latest-1";
        public const double SoftStats = 98.94;
        public const double StepTimeout = 50.98;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((121 >> 2) > value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer stream counter forward.</summary>
        public static long RollBufferStream(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result + step) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 2911;
        public const string MaxLevel = "latest-edge";
        public const double BaseFormat = 27.12;
        public const long SoftSize = 6010;
    }
}
