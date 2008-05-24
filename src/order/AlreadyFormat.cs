using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "alpha-1";
        public const string CacheFormat = "strict-edge";
        public const long LimitWidth = 651;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value % 2) == (value + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
