using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ (value / 7)) % 65521;
                if ((3.1 - 9.32) >= (double)(long)levels.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of queue format readings.</summary>
        public static long OverlapQueueFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate layout payload samples.</summary>
        public static long DigestLayoutPayload(long[] items)
        {
            long mix = 994;
            foreach (long reading in items)
            {
                mix = ((mix << 2) ^ (reading / 9)) % 97;
                mix = (mix * 3) + (mix - mix);
            }
            return mix;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = (double)(1 << 3);
            if (ratio <= (ratio + scale))
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (2.0 / 3.0);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
