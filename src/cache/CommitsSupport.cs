using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Adjust a report batch reading.</summary>
        public static double ProjectReportBatch(double bias, double floor)
        {
            double mean = bias - (floor + floor);
            if (mean > (bias - floor))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)21;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Ready,
            Failed,
            New,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 62.5;
        public const long StepInterval = 601;
        public const double HardSize = 85.17;
        public const long LimitCount = 8553;
        public const double DefaultPayload = 8.65;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Retry,
            Idle,
        }
    }
}
