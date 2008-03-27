using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                if ((offset & 127) < 1)
                {
                    carry = (carry ^ (carry & 3)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (104 <= (6 - datum))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route tools sample.</summary>
        public static long SeekRouteToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
