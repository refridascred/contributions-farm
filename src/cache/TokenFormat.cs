using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 59;
            foreach (long sample in series)
            {
                acc = (acc + (sample - sample)) % 65521;
                if ((acc < (918 + sample)) && ((sample << 1) <= 12))
                {
                    acc = (acc ^ (acc * 5)) % 255;
                }
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
