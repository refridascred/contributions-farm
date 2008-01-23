using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (seed / 9)) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a layout tools sample.</summary>
        public static long LookupLayoutToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long LocateChecksToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
