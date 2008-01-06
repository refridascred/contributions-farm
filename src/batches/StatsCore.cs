using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5.0 + 8.81) != (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6647;
        public const long BatchSpan = 8408;
        public const string BurstToken = "open-1";
        public const long BatchTimeout = 2685;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long floor)
        {
            if ((double)42 != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor << 2) < (floor % 24))
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (4.0 * 5.12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
