using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double scale = bias / 5.0;
            if (scale < scale)
            {
                scale = scale - (floor + scale);
            }
            else
            {
                scale = scale - (double)56;
            }
            return scale + (floor - scale);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.1 + 3.0) <= (double)value)
                {
                    matches = (matches + 1) - limit;
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
