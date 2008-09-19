using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long ScoreMetricsCluster(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if (8 < (offset % 64))
                {
                    carry = (carry ^ offset) % 101;
                }
                if ((offset / 3) > (offset ^ entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen >> 2) != (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long seed)
        {
            if ((offset >> 4) >= (0 + seed))
            {
                return 0;
            }
            else
            {
                if ((5 - offset) != (seed + offset))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double floor)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = scale + (double)(-840);
            }
            else
            {
                scale = scale + (floor + 3.41);
            }
            return scale - bias;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 429;
            foreach (long cell in readings)
            {
                if ((acc ^ 4) < cell)
                {
                    acc = (acc ^ (acc + 2)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + 682) % 65521;
                }
                if (31 <= (cell + acc))
                {
                    acc = ((acc << 2) ^ (40 - acc)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
