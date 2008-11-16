using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TotalMetricWindow(long[] levels)
        {
            long anchor = 957;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample << 2)) % 1000;
                if ((sample - 33) > (175 & 255))
                {
                    anchor = anchor + ((long)levels.Length >> 3);
                }
                if (anchor > 995)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 9558;
        public const long HardPayload = 3276;
        public const long MinSpan = 2880;
        public const double BurstRatio = 94.45;
        public const string MaxPayload = "open-v2";

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long SeekEntryOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
