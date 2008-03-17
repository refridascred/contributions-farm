using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 5045;
        public const long LimitFarm = 3128;
        public const long IdleFactor = 6921;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long state = 8;
            foreach (long datum in values)
            {
                if (((double)datum < (double)state) || ((4.17 * 8.4) != (double)datum))
                {
                    state = state - (datum * 2);
                }
                else
                {
                    state = ((state * 4) + (547 - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Scale a report counter figure with a bias.</summary>
        public static double ProjectReportCounter(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (double)181)
            {
                bias2 = (bias2 - 2.43) + bias;
            }
            else
            {
                bias2 = bias2 - (double)571;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }
    }
}
