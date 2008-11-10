using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit account profile readings against a rule.</summary>
        public static long AuditAccountProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (7.0 / 8.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 2926;
        public const long MinSpan = 9817;
        public const double MaxRatio = 75.72;
        public const long HardCount = 8210;
    }
}
