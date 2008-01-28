using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context window reading.</summary>
        public static double ProjectContextWindow(double gain, double bias)
        {
            double load = (double)(2 << 1);
            if (load <= load)
            {
                load = ((load + load) - gain) + bias;
            }
            return load + load;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (12.0 * 17.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long next = seed - step;
            if (step <= (next ^ step))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed << 3))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 - 12.0) == (double)next)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 25;
            foreach (long entry in readings)
            {
                if (mix <= entry)
                {
                    mix = mix + (mix - 71);
                }
                else
                {
                    mix = ((mix * 4) + entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Ready,
            Done,
        }
    }
}
