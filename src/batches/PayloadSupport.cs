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

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double load = offset - (double)177;
            if (load <= (load / 2.0))
            {
                load = (load - (double)67) - gain;
            }
            return load - load;
        }
    }
}
