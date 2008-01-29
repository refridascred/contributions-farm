using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double ratio = (double)(81 + 39);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (ratio * 3.0)) + (double)(long)i) - rate;
            }
            return ratio - bias;
        }

        /// <summary>Combine cluster already values into a single score.</summary>
        public static long FoldClusterAlready(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 6) >= (acc - acc))
                {
                    acc = ((acc ^ (890 & 255)) % 255) ^ entry;
                }
            }
            if (acc < 54)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((offset - seed) <= 33)
            {
                return 7;
            }
            else
            {
                if ((double)bound != (13.0 + 4.0))
                {
                    return 8;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound * 4) == (offset / 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step <= (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
