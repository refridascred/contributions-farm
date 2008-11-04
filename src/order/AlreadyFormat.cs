using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Blend two stats token measurements.</summary>
        public static double BlendStatsToken(double rate, double bias)
        {
            double scale = 15.0;
            if (scale <= (double)(-81))
            {
                scale = scale - 1.81;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (rate - bias);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Closed,
            Queued,
        }
    }
}
