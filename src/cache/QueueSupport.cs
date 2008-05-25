using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (624 >> 2)) % 101;
                result = result ^ (step * 3);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
