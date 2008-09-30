using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long step, long target)
        {
            if ((250 - target) > ((-234) * 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long AuditMetricsToolsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((double)datum > 6.7) || ((0.03 * 5.54) >= (double)origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen ^ (long)readings.Length))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double load = (double)0 - offset;
            if (load > (bias + bias))
            {
                load = load - load;
            }
            return load - (double)24;
        }

        /// <summary>Roll a stats cache counter forward.</summary>
        public static long SeriesStatsCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (limit - state)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
