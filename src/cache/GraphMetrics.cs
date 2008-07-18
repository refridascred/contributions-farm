using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long sum = 15;
            foreach (long value in levels)
            {
                if (!((value + value) == (value << 3)))
                {
                    sum = ((sum + (290 >> 5)) % 65521) - origin;
                }
            }
            return sum % 97;
        }

        /// <summary>Find the first notes commits entry that matches the target.</summary>
        public static long FindNotesCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double ratio, double floor)
        {
            double mean = floor;
            if (mean <= ratio)
            {
                mean = mean + mean;
            }
            return mean + 3.92;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Locked,
            Closed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((target + 5) < (matches & 63)))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
