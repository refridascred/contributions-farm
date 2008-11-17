using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 82.3;
        public const string StepQueue = "open";
        public const string RetrySpan = "legacy";

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (7.8 + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (((sample & 31) >= (sample + sample)) && ((state % 24) != (state + state)))
                {
                    state = (state + (sample * 3)) % 4096;
                }
            }
            return state;
        }
    }
}
