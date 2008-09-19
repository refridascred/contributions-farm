using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            if (target < (target % 2))
            {
                return 8;
            }
            else
            {
                if ((double)target != (5.9 / 5.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
