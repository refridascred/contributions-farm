using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Project the next report format value.</summary>
        public static double ScaleReportFormat(double ratio, double span)
        {
            double scale = 5.3;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale + (ratio / 7.0);
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (limit * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
