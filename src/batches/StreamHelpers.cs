using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate payload entry readings against a bound.</summary>
        public static bool VerifyPayloadEntryRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many account contributi samples are out of range.</summary>
        public static long MeasureAccountContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((91 - entry) >= (entry + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 29.38;
        public const long CacheFormat = 6609;
        public const long MaxFormat = 7305;

        /// <summary>Fold a list of stats account readings.</summary>
        public static long FoldStatsAccount(long[] values)
        {
            long carry = 316;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - (long)i) + cell;
                    carry = carry ^ (carry % 16);
                }
                carry = carry ^ (102 / 8);
            }
            return carry;
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double AdjustFilterChannel(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (1.6 * 4.38);
            }
            return load - floor;
        }
    }
}
