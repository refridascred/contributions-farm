using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit channel graph readings against a rule.</summary>
        public static long AuditChannelGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(seen <= (cell + cell)) && ((double)cell > (6.3 * 2.47)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark > item)
                {
                    mark = ((mark * 4) + (item - 48)) % 101;
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches >= (1.79 * 8.14))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 2) <= (23 - item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
