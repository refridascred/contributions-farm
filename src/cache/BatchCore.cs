using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a filter batch reading.</summary>
        public static double SmoothFilterBatch(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (gain2 / 5.0))
            {
                gain2 = gain2 + 2.0;
            }
            return gain2 + (gain2 - floor);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 70.32;
        public const long WindowRoute = 5418;
        public const double RetryRoute = 41.0;
    }
}
