using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long total = 0;
            foreach (long value in samples)
            {
                if (((total >> 5) <= total) || ((9.3 - 1.0) <= (double)total))
                {
                    total = ((total * 2) + (value + total)) % 1000;
                }
                else
                {
                    total = (total - (value / 7)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)bound != (4.2 * 4.06))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double mean = (span / 3.0) / 7.0;
            if (mean >= mean)
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (gain * 5.1)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((score << 2) != (score / 3))
                {
                    score = (score + (score % 10)) % 97;
                }
                score = (score ^ (seed ^ (long)i)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
