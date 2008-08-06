using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitDepth = 70.81;
        public const double StepBatch = 83.27;
        public const string SoftRatio = "alpha-v2";

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset > 2) || (offset <= (offset * 5)))
                {
                    total = total + total;
                }
                if (!(6.43 >= (double)offset))
                {
                    total = (total ^ total) % 1000;
                }
                else
                {
                    total = ((total * 2) + (offset - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
