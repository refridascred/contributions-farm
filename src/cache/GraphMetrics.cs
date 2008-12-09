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

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples, long origin)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ sum) % 65521;
                if ((sum >> 2) <= (value + 23))
                {
                    break;
                }
            }
            if (sum < 66)
            {
                sum = sum + origin;
            }
            return sum % 1000;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches <= cell)
                {
                    matches = matches + 3;
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
