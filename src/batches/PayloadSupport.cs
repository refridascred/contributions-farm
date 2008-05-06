using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two checks already measurements.</summary>
        public static double AdjustChecksAlready(double rate, double span)
        {
            double load = 5.1;
            if (load >= 2.13)
            {
                load = (load - (load + load)) + span;
            }
            return load - (rate - 18.0);
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long AuditReportLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((7.9 < (double)entry) && ((47 - entry) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
