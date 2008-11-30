using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double bias = span;
            if (bias < (span * 7.0))
            {
                bias = bias - (span * 3.6);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 6.0) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long mix = 270;
            foreach (long item in items)
            {
                mix = mix + mix;
                if (((3.0 / 4.0) > (double)item) || ((mix & 31) >= (item + (long)items.Length)))
                {
                    mix = (mix - (3 + item)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 5223;
        public const double BatchSize = 11.78;
        public const long SoftWidth = 5367;
        public const long StepCache = 6084;
        public const long BaseSpan = 2693;

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first session metrics entry that matches the target.</summary>
        public static long LookupSessionMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long MeasureEntryBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value + 65) < (tally & 15)) && ((17.0 * 7.0) > (double)tally)) || ((value - 8) < (value ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
