using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long CountAlreadyPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((4.08 * 3.59) > (double)tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((origin >> 3) <= seen) || (((sample * 4) >= (251 - seen)) || (seen <= (origin % 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
