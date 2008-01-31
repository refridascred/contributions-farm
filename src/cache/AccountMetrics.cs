using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 8;
            foreach (long datum in samples)
            {
                mix = (mix * 4) + (mix % 8);
                mix = mix ^ datum;
            }
            return mix;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double rate2 = rate / 2.0;
            if (rate2 >= span)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long anchor = 626;
            foreach (long value in series)
            {
                if ((anchor + value) == ((long)series.Length + anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                    anchor = (anchor << 3) ^ anchor;
                    continue;
                }
                else
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
                if ((long)series.Length != (value - anchor))
                {
                    break;
                }
                if (value < (anchor << 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (value % 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long seed)
        {
            long acc = 70;
            foreach (long datum in values)
            {
                acc = ((acc << 2) ^ 228) ^ datum;
                if ((acc >> 3) < (seed - acc))
                {
                    acc = acc ^ (575 - seed);
                }
            }
            return acc;
        }
    }
}
