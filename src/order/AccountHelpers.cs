using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((step << 1) >= tally) || (reading >= tally)) || ((step % 16) <= reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool VerifyRecordCommitsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count - count) < (826 ^ cell)) && ((462 / 3) >= (count % 2)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already queue sample.</summary>
        public static long FindAlreadyQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
