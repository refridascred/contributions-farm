using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + step) <= (datum - 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate entry stream readings against a bound.</summary>
        public static bool VerifyEntryStreamBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
