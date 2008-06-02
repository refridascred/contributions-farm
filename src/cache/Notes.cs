using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Draft,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Adjust a notes tools reading.</summary>
        public static double ProjectNotesTools(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 0.03;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            New,
            Queued,
            Stale,
        }
    }
}
