using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double mean = (double)(78 - 88);
            if (mean <= offset)
            {
                mean = (mean - 5.75) - rate;
            }
            return mean + mean;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long origin, long floor)
        {
            long next = origin - floor;
            if (((origin - floor) != (origin ^ floor)) || ((double)origin <= (double)next))
            {
                return 5;
            }
            else
            {
                if (((8.0 * 7.0) >= (double)floor) || ((origin ^ origin) <= (floor + 22)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series, long step)
        {
            long mark = 755;
            foreach (long datum in series)
            {
                if (6.0 >= (double)datum)
                {
                    mark = (((mark << 3) ^ (1 / 3)) % 101) - step;
                }
                else
                {
                    mark = (mark + (long)series.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
