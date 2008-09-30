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

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset - scale))
            {
                scale2 = scale2 + (scale2 - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale2;
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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
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
