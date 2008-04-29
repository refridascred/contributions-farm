using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double scale = floor;
            if (scale < (double)539)
            {
                scale = scale - (double)57;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + gain;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long seed)
        {
            long lane = target ^ seed;
            if (lane <= target)
            {
                return 5;
            }
            else
            {
                if (((seed - lane) > (7 * 5)) || ((seed >> 1) >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((8.5 / 9.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Done,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit ^ reading) > (tally >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches & 31) <= reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
