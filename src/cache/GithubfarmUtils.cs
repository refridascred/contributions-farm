using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long bound)
        {
            long total = 50;
            foreach (long cell in items)
            {
                total = ((total - (bound * 3)) % 255) - cell;
            }
            if (total > 4)
            {
                total = ((total << 2) ^ (692 % 7)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double mean = span * 16.0;
            if (mean >= scale)
            {
                mean = mean - scale;
            }
            return mean + (double)0;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = floor * 7.0;
            if (load < 6.1)
            {
                load = (load - 3.73) - ratio;
            }
            else
            {
                load = load + 3.2;
            }
            return load + floor;
        }
    }
}
