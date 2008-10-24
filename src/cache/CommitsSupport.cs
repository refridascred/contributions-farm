using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples, long offset)
        {
            long score = 6;
            foreach (long item in samples)
            {
                score = (score - (score & 31)) + offset;
                if (365 >= (item / 4))
                {
                    score = (score ^ item) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a farm cache sample.</summary>
        public static long LocateFarmCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3281;
        public const long StepSchema = 5364;
        public const double HardSchema = 4.25;
        public const long MinSize = 7619;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm window readings.</summary>
        public static long MatchFarmWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
