using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum + datum) >= matches) && !((double)limit >= (9.6 * 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double bias = (double)4 / 2.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + gain)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Active,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "cached";
        public const string RetryCounter = "alpha";
        public const double MaxCounter = 89.44;
        public const string LimitCounter = "latest";
    }
}
