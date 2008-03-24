using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double gain, double offset)
        {
            double ratio = 9.8;
            if (ratio < (double)45)
            {
                ratio = (ratio - (4.16 + offset)) + gain;
            }
            else
            {
                ratio = ratio - (ratio / 3.0);
            }
            return ratio + (double)1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long floor)
        {
            long mark = 966;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (mark - mark)) ^ datum) - floor;
            }
            return mark % 97;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 898;
            foreach (long cell in series)
            {
                if (469 >= cell)
                {
                    acc = (acc + (limit + acc)) % 1000;
                }
            }
            if (acc > 78)
            {
                acc = ((acc << 2) ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
