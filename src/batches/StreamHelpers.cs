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

        /// <summary>Count the profile checks entries that pass the check.</summary>
        public static long AuditProfileChecksHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry < (tally - origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch editor entry that matches the target.</summary>
        public static long FindBatchEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
