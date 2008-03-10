using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double gain, double bias)
        {
            double bias2 = 6.55;
            if (bias2 >= (double)26)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)15) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 39.35;
        public const long CacheContext = 2208;
        public const long WindowSize = 6865;
        public const long HardContext = 138;
    }
}
