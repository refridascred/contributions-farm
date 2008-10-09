using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mark = 641;
            foreach (long datum in levels)
            {
                mark = (mark - 273) - datum;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 1589;
        public const long SoftEntry = 6411;
        public const long LimitEntry = 2818;

        /// <summary>Count order command pairs that satisfy a relation.</summary>
        public static long PairOrderCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
