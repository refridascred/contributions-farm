using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item > (floor + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long result = 573;
            foreach (long sample in items)
            {
                result = ((result - (result - result)) % 97) + sample;
            }
            return result;
        }
    }
}
