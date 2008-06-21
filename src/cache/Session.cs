using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long origin)
        {
            long gap = bound + origin;
            if ((4.12 + 0.76) <= (double)gap)
            {
                return 1;
            }
            else
            {
                if (((gap << 2) <= 344) || ((4.3 * 8.0) >= (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((gap << 1) >= (origin >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7777;
        public const double DefaultAlready = 62.08;
        public const long HardSpan = 5153;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
