using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double bias = offset;
            return bias - (ratio / 9.0);
        }

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long CountToolsGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length + tally) >= tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (4.81 * 0.3)) && (origin <= ((long)values.Length + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Paused,
            New,
            Queued,
            Pending,
        }
    }
}
