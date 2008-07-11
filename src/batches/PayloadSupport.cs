using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((limit + 128) >= seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits layout reading by value.</summary>
        public static long FindCommitsLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    mark = ((mark - ((long)i + origin)) % 97) ^ (long)i3;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
