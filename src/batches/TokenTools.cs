using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi report samples are out of range.</summary>
        public static long CountContributiReportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((sample * 4) < (tally - sample)) || ((double)sample <= (8.53 / 6.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long origin)
        {
            long cur = seed - origin;
            if ((2.91 + 2.9) >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((origin & 63) > cur)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
