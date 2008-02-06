using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long AuditSupportWindowMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= matches)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph token figure with a bias.</summary>
        public static double ProjectGraphToken(double ratio, double offset)
        {
            double mean = (double)90 * 5.2;
            if (mean >= 0.57)
            {
                mean = (mean - (offset - 19.0)) - ratio;
            }
            return mean + (double)6;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels)
        {
            long state = -123;
            foreach (long entry in levels)
            {
                if ((state ^ entry) <= (entry * 4))
                {
                    state = (state * 3) + (entry % 2);
                }
                state = (state - (8 ^ 76)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
