using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count % 64) >= 18)
                {
                    count = ((count + 3) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
