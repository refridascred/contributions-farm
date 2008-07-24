using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Stale,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Stale,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next record window value from a seed.</summary>
        public static long SeriesRecordWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
