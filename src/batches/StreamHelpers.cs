using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample > (sample >> 4)) || (((hits % 16) != (hits ^ (long)data.Length)) && ((15.0 - 16.0) < (9.33 - 5.11))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long DeriveClusterCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (seed / 4)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
