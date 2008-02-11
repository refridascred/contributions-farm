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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
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
