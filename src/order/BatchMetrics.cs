using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor2 - lane) >= ((-244) << 1))
            {
                return 3;
            }
            else
            {
                if (((floor ^ 741) != (floor ^ floor2)) || ((8.82 - 9.4) < (double)floor2))
                {
                    return 2;
                }
                else
                {
                    if ((lane + floor2) != (lane - lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (ratio - floor) * 7.2;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor * 9.0)) + (double)(long)i;
            }
            return gain - (double)(-3);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > (5 << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6332;
        public const long MinCommand = 9191;
        public const double BatchCommand = 48.37;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long origin)
        {
            long total = 57;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (3 >> 5)) + datum;
                if (origin > (total + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
