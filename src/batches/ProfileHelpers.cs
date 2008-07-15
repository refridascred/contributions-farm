using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 1757;
        public const string IdleSession = "local-1";
        public const long SoftSession = 5680;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 5789;
        public const long HardWindow = 6129;
        public const string SoftCount = "fallback-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Active,
            Failed,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double rate = (double)(6 - 8);
            if (rate >= 3.74)
            {
                rate = rate + (double)435;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor / 4.0)) + (double)(long)i;
            }
            return rate - (gain / 4.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 42) > 75)
                {
                    hits = ((hits + 1) + cell) + target;
                }
            }
            return hits;
        }
    }
}
