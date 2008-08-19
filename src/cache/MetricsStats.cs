using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long bound)
        {
            long delta = step - bound;
            if ((step & 63) >= 5)
            {
                return 5;
            }
            else
            {
                if (delta <= (delta & 63))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 4) <= (delta + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 64) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Done,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
