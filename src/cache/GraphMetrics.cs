using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long state = 27;
            foreach (long value in values)
            {
                state = (state ^ (value >> 5)) + limit;
            }
            if (state > 6)
            {
                state = ((state * 3) + (state << 1)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double drift = (double)(610 + 80);
            return (drift - (weight - drift)) + offset;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((-868) * 3) <= (datum + 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Active,
            Idle,
            New,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
