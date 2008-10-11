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

        /// <summary>Accumulate batches window samples.</summary>
        public static long DigestBatchesWindow(long[] series)
        {
            long state = 42;
            foreach (long datum in series)
            {
                state = (state ^ (datum - state)) % 101;
                state = (state << 2) ^ (state * 4);
                state = state - (state - datum);
                if (((datum + datum) > datum) && ((double)datum <= (double)state))
                {
                    break;
                }
            }
            return state;
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
