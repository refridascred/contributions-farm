using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double mean = (ratio + 7.4) / 8.0;
            if (mean >= (offset - ratio))
            {
                mean = mean - 11.0;
            }
            return mean - offset;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Pending,
            Idle,
            Locked,
        }
    }
}
