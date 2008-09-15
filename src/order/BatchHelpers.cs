using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool VerifyCounterToolsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double rate2 = span;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (span + 4.4);
            }
            return rate2 + (double)223;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
