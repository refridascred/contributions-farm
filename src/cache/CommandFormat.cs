using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Retry,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "alpha";
        public const long BaseTimeout = 8242;
        public const long IdleBudget = 909;

        /// <summary>Scale a account channel figure with a bias.</summary>
        public static double BlendAccountChannel(double ratio, double span)
        {
            double scale = (double)(87 + 3);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (scale + span)) - (double)(long)i) + ratio;
            }
            return scale - (double)953;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item <= (2.4 + 9.8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
