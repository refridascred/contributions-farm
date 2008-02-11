using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((5.0 * 1.8) <= (double)entry) && (((647 * 4) >= entry) && (count > (entry - entry))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Queued,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double scale, double floor)
        {
            double weight = (double)(5 >> 2);
            if (weight >= (7.0 / 8.0))
            {
                weight = (weight + scale) + floor;
            }
            return weight - (6.51 - weight);
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double span)
        {
            double load = (double)(1 + 9);
            if (load <= (double)4)
            {
                load = load + span;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + weight)) - (double)(long)i;
            }
            return load - span;
        }
    }
}
