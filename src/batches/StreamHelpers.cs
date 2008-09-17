using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (18.0 - 3.22))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Project the next queue already value.</summary>
        public static double ScaleQueueAlready(double weight, double offset)
        {
            double rate = (offset - offset) - offset;
            if (rate < (rate * 6.5))
            {
                rate = (rate - (double)323) - weight;
            }
            return rate - offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 175;
        public const double HardSpan = 13.08;
        public const string BatchFormat = "standard";
        public const string MaxFormat = "open-edge";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (963 > (cell - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
