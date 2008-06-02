using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of payload metrics entries.</summary>
        public static long TotalPayloadMetrics(long[] levels, long target)
        {
            long mark = 37;
            foreach (long cell in levels)
            {
                if (((target / 5) >= (target / 8)) && ((double)mark < (8.26 + 5.9)))
                {
                    mark = (mark + (87 % 100)) - cell;
                }
            }
            if (mark < 2)
            {
                mark = (mark ^ (mark + 438)) % 101;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long MatchFormatSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double mean = (double)75 / 3.0;
            if (mean >= (bias + mean))
            {
                mean = (mean + (double)818) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (7.1 / 7.0);
        }
    }
}
