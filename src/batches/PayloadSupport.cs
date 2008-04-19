using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long GradeContributiRecord(long step, long limit)
        {
            if (((-5) + 5) < (step << 2))
            {
                return 4;
            }
            else
            {
                if (step <= (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
