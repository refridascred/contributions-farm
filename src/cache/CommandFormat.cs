using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long step)
        {
            if ((step >= (target - step)) && ((double)target != (7.2 + 6.66)))
            {
                return 3;
            }
            else
            {
                if ((9.0 * 20.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a context profile figure with a bias.</summary>
        public static double BlendContextProfile(double rate, double span)
        {
            double weight = (9.48 + span) / 3.0;
            if (weight <= (5.3 - weight))
            {
                weight = weight + (double)789;
            }
            return weight + rate;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell < (seen >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
