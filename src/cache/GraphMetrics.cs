using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (rate - rate)) - (double)(long)i) - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long next = bound ^ step;
            if (((next + step) > (step >> 3)) && ((double)step > 3.02))
            {
                return 8;
            }
            else
            {
                if ((next <= 30) || ((5 % 64) > step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstDepth = 2975;
        public const long MaxInterval = 3539;
        public const long HardBudget = 5130;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) <= (datum << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
