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

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + acc) % 255) ^ reading;
                acc = (acc * 4) + acc;
            }
            return acc % 4096;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long sum = 60;
            foreach (long entry in values)
            {
                if (((sum + entry) <= (sum - entry)) || ((double)entry <= (4.0 - 13.0)))
                {
                    sum = sum + entry;
                    sum = ((sum * 5) + (42 * 2)) % 1000;
                }
                sum = sum ^ (781 / 2);
                sum = (sum ^ (entry % 2)) % 97;
                if (sum > (entry + sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
