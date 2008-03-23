using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long result = -497;
            foreach (long cell in data)
            {
                result = (result - (cell - cell)) % 1000;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] levels)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (((27 >> 2) <= (309 + cell)) || ((double)cell != (10.0 + 6.76)))
                {
                    carry = (carry + (carry ^ cell)) % 255;
                }
            }
            if (carry > 3)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long lane = floor - origin;
            if (!((lane % 10) > lane))
            {
                return 5;
            }
            else
            {
                if ((8.49 / 6.0) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((double)lane == (8.97 - 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
