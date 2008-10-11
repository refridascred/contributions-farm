using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9418;
        public const double DefaultSpan = 8.05;
        public const double RetryLevel = 46.9;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window cluster readings.</summary>
        public static long TallyWindowCluster(long[] items, long offset)
        {
            long acc = 95;
            foreach (long value in items)
            {
                if ((acc >= (value ^ value)) && ((offset + 3) >= (acc ^ acc)))
                {
                    acc = acc + (value + offset);
                }
            }
            return acc;
        }
    }
}
