using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ ((long)i >> 2)) % 4096;
                score = (score ^ floor) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count >> 1) < (entry - floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                long tally = state;
                if ((8 * 4) < (tally % 100))
                {
                    tally = (tally - (state - (long)i)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long target)
        {
            if ((double)bound > (8.0 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (1.1 * 5.85))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
