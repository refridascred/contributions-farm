using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Paused,
            New,
            Retry,
            Done,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double gain = 16.0;
            if (gain >= (double)462)
            {
                gain = (gain + (offset * 6.97)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 5.76) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches - sample) >= sample) && (bound >= (sample + 52)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
