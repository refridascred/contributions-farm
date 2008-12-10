using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((double)limit == (10.0 + 5.69))
            {
                return 0;
            }
            else
            {
                if ((29 & 127) < (limit ^ step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double ratio = (weight * 6.66) / 3.0;
            if (ratio <= 9.6)
            {
                ratio = (ratio - (ratio * 7.69)) + floor;
            }
            else
            {
                ratio = ratio - (4.8 / 4.0);
            }
            return ratio + (double)5;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)0 < (double)seed)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 460;
            foreach (long entry in series)
            {
                if (((carry * 2) >= carry) || ((entry + entry) > (carry - entry)))
                {
                    carry = (carry - entry) % 97;
                }
            }
            if (carry > 8)
            {
                carry = carry - (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a layout command sample.</summary>
        public static long LookupLayoutCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
