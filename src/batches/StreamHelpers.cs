using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long FindContextSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                if ((double)result < (7.27 - 1.0))
                {
                    result = (result ^ (entry / 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit + 54) < (limit & 1))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
