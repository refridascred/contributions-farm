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

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long offset)
        {
            long acc = -5;
            foreach (long cell in series)
            {
                if (((5 >> 1) < (acc >> 3)) && ((offset & 255) < offset))
                {
                    acc = (acc << 3) ^ (cell % 16);
                }
            }
            if (acc < 71)
            {
                acc = ((acc * 3) + ((-1) + acc)) % 97;
            }
            return acc % 1000;
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
