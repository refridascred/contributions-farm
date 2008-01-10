using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long target)
        {
            long offset = origin - target;
            if ((double)target > 12.0)
            {
                return 1;
            }
            else
            {
                if (((1.35 - 5.6) <= (double)offset) || ((offset / 3) >= (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (422 > ((long)series.Length << 1))
                {
                    matches = ((matches + 1) ^ sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.3 * 8.17) != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
