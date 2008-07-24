using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long lane = floor - floor2;
            if (((double)lane == (double)floor2) && ((lane % 24) != (floor >> 2)))
            {
                return 8;
            }
            else
            {
                if (((5.55 * 8.9) >= (double)lane) || ((lane - floor2) != (floor2 << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (19.0 + 8.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long step)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc + 573) + (long)i;
                }
                if ((step - step) < (19 + step))
                {
                    acc = ((acc << 2) ^ (-4)) % 101;
                }
                else
                {
                    acc = acc + entry;
                }
            }
            return acc;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long offset)
        {
            long result = 9;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result - (sample / 5)) % 65521) ^ (long)i) - offset;
                }
                if ((sample + result) >= 846)
                {
                    result = (result - (result ^ 56)) % 101;
                }
            }
            if (result > 792)
            {
                result = (result ^ (result ^ 9)) % 1000;
            }
            return result;
        }
    }
}
