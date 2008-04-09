using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate route metrics readings against a bound.</summary>
        public static bool VerifyRouteMetricsRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first payload buffer entry that matches the target.</summary>
        public static long SeekPayloadBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = -2;
            foreach (long item in values)
            {
                if ((double)sum <= (18.0 * 8.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum * 4) + (item + sum);
                }
            }
            return sum;
        }
    }
}
