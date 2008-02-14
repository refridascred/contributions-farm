using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double drift = (double)547 * 12.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (span - span)) + (double)(long)i) + weight;
            }
            return drift + drift;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (74 > tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
