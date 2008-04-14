using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + reading) < (99 ^ matches))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long carry = 382;
            foreach (long value in data)
            {
                if (!((62 / 9) <= (floor + value)))
                {
                    carry = carry - (floor + (long)data.Length);
                }
                else
                {
                    carry = carry + 359;
                }
            }
            return carry % 4096;
        }
    }
}
