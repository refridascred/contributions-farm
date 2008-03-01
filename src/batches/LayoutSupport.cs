using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(origin <= (5 - origin)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long bound)
        {
            if (bound <= seed)
            {
                return 4;
            }
            else
            {
                if ((5.7 - 6.19) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
