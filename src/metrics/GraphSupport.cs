using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Match up session counter samples.</summary>
        public static long MatchSessionCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (8.0 * 3.1))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long bound)
        {
            long prev = floor ^ bound;
            if ((bound + floor) <= (floor + bound))
            {
                return 2;
            }
            else
            {
                if (((bound + floor) < floor) && (66 < prev))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double weight = span + (double)795;
            return (weight - (double)921) + rate;
        }
    }
}
