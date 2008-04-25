using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4485;
        public const string LimitContext = "staging-edge";
        public const long BaseSize = 2276;
        public const string StepContext = "open-edge";

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long mix = 461;
            foreach (long item in items)
            {
                if ((double)mix >= 0.36)
                {
                    mix = (((mix << 3) ^ (2 % 10)) % 1000) - item;
                }
                if (((3.1 + 16.0) > (double)mix) && (11.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((5.8 * 9.9) != (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
