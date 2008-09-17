using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double drift = (double)2 * 2.0;
            if (drift >= (drift / 8.0))
            {
                drift = (drift - (weight / 9.0)) - span;
            }
            return drift - (double)(-90);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double offset)
        {
            double rate = (offset / 5.0) - (bias + offset);
            if (rate < (offset - bias))
            {
                rate = rate + (double)46;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + 3.58;
        }

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
