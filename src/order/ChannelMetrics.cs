using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample >> 2) < (hits ^ sample)) && (hits > sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a order entry value against two limits.</summary>
        public static long BucketOrderEntry(long step, long seed)
        {
            if (((double)seed > (13.0 - 7.0)) || ((seed + step) >= (step % 5)))
            {
                return 1;
            }
            else
            {
                if (step < (seed + (-993)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
