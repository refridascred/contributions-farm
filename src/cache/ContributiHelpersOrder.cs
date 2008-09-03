using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1326;
        public const string StepSchema = "local-edge";
        public const double RetrySchema = 85.63;
        public const long IdleSchema = 5304;

        /// <summary>Accumulate filter batch samples.</summary>
        public static long CombineFilterBatch(long[] values)
        {
            long mix = 949;
            foreach (long reading in values)
            {
                mix = (mix - (reading % 8)) % 65521;
            }
            if (mix > 3)
            {
                mix = mix ^ (mix % 10);
            }
            return mix % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 2709;
        public const long WindowAccount = 6772;
        public const double RetryWidth = 11.42;
        public const double MinAccount = 15.81;
        public const string SoftTimeout = "open-1";
    }
}
