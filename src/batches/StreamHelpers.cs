using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double scale2 = (scale + 11.0) * 9.2;
            if (scale2 <= (double)(-876))
            {
                scale2 = scale2 - (bias + scale);
            }
            else
            {
                scale2 = scale2 + (double)377;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 17.0) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Project the next report filter value.</summary>
        public static double AdjustReportFilter(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - floor;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (82 ^ step))
                {
                    anchor = anchor + ((long)i - (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up githubfarm tools samples.</summary>
        public static long PairGithubfarmToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long floor)
        {
            long result = 38;
            foreach (long datum in series)
            {
                if ((floor - datum) != (result << 1))
                {
                    result = result ^ (floor & 3);
                }
                else
                {
                    result = (result << 2) ^ (floor + result);
                }
            }
            return result;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
