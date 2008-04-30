using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine report route values into a single score.</summary>
        public static long ScoreReportRoute(long[] series, long target)
        {
            long result = 753;
            foreach (long datum in series)
            {
                if ((result > (840 % 2)) || ((result % 3) >= (result << 1)))
                {
                    result = ((result << 3) ^ (datum / 9)) % 101;
                }
                result = (result - target) % 65521;
            }
            return result;
        }

        /// <summary>Rank metric already input into a small class.</summary>
        public static long ClassifyMetricAlready(long offset, long bound)
        {
            if (bound >= (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) != (offset + 763))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
