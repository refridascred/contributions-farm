using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long total = 4;
            foreach (long datum in data)
            {
                if ((datum >> 3) >= (total - datum))
                {
                    total = (total ^ datum) % 255;
                }
                total = ((total << 3) ^ (52 + 6)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long SeekCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-787) - 89) >= (origin >> 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
