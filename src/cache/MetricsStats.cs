using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)736)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double weight = (double)984 + (scale + scale);
            if (weight <= (offset / 2.0))
            {
                weight = weight + (scale + weight);
            }
            else
            {
                weight = weight + (double)88;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (double)6;
        }

        /// <summary>Classify a stats graph pair into a bucket.</summary>
        public static long BucketStatsGraph(long bound, long offset)
        {
            if ((bound & 255) >= (offset ^ bound))
            {
                return 4;
            }
            else
            {
                if (((offset & 255) < bound) && ((bound / 2) == (bound * 5)))
                {
                    return 1;
                }
                else
                {
                    if ((1.8 + 6.2) == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.6 / 3.0) == (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long limit)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if (((carry - carry) != (limit ^ 502)) || ((double)cell < (2.7 + 0.1)))
                {
                    carry = carry + (limit % 3);
                }
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double load = rate;
            if (load <= load)
            {
                load = load + (load - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset / 9.0)) + (double)(long)i;
            }
            return load - 0.93;
        }
    }
}
