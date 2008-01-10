using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double ratio = (double)(57 + 8);
            if (ratio >= (weight / 5.0))
            {
                ratio = (ratio + ratio) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (double)43;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long OverlapRouteStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((0.7 / 8.0) > (7.27 / 9.0))
                {
                    carry = (carry - ((long)i / 9)) % 97;
                }
                carry = (carry ^ ((-404) % 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
