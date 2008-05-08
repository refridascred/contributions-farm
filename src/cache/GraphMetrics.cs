using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long CompareStatsMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double mean = 12.0 + floor;
            if (mean <= (double)55)
            {
                mean = mean + 9.2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits < 17.0)
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                bool ok = !((sum + 82) < (origin + origin));
                if ((sum > origin) || ok)
                {
                    sum = (sum - (long)i) % 4096;
                }
                if (!((double)(long)i != (8.0 + 4.6)))
                {
                    ok = ((sum & 255) == (sum - 689)) || ((long)i < sum);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
