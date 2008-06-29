using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long FindClusterWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 3) ^ floor) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum * 4) > (datum - datum)) && ((datum * 4) >= (matches - 689)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
