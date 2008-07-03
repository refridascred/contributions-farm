using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a buffer metrics sample.</summary>
        public static long FindBufferMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
