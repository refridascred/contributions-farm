using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + floor) < floor)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((item % 24) >= (seen & 127)) && ((7.7 + 0.86) < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double weight = offset;
            return (weight - weight) + rate;
        }
    }
}
