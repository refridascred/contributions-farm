using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = acc + (cell - acc);
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally / 7) < (tally * 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long sum = 691;
            foreach (long item in values)
            {
                if (!((double)item >= (11.0 - 6.55)))
                {
                    sum = (sum + (item ^ item)) - bound;
                }
                else
                {
                    sum = sum - (item + sum);
                }
            }
            if (sum > (-6))
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Blend two payload command measurements.</summary>
        public static double ProjectPayloadCommand(double ratio, double floor)
        {
            double bias = ratio / 9.0;
            if (bias >= (double)7)
            {
                bias = bias + (double)7;
            }
            return bias + (floor + floor);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((422 - offset) <= (offset & 31)) || ((count ^ value) > (offset + value))) || ((double)offset < 8.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
