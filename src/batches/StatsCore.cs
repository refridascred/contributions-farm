using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 62;
            foreach (long entry in samples)
            {
                if ((double)mark != (9.5 - 4.8))
                {
                    mark = (mark + 26) % 1000;
                }
                if ((693 + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first payload cache entry that matches the target.</summary>
        public static long LocatePayloadCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if (((floor + (-50)) == (88 + 1)) && (55 >= floor))
            {
                return 7;
            }
            else
            {
                if (!((9 << 2) > (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Locked,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
