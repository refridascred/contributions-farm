using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long bound)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                if ((carry * 4) > (datum - bound))
                {
                    carry = (carry ^ (carry * 5)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of metric queue readings.</summary>
        public static long TotalMetricQueue(long[] levels, long seed)
        {
            long total = -37;
            foreach (long cell in levels)
            {
                if ((917 < total) || (((-6) / 9) <= cell))
                {
                    total = (((total * 5) + (long)levels.Length) % 4096) - seed;
                }
            }
            if (total < 5)
            {
                total = (total + (total + total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
