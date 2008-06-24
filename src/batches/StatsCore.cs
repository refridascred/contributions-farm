using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of schema token readings.</summary>
        public static long OverlapSchemaTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long DigestMetricsGraph(long[] values)
        {
            long result = 620;
            foreach (long item in values)
            {
                if (((3.0 + 3.5) >= (double)item) && ((item + result) <= item))
                {
                    result = (result * 5) + item;
                }
                else
                {
                    result = ((result << 2) ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double bias = gain;
            if (bias <= (double)8)
            {
                bias = (bias + bias) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain / 9.0)) + (double)(long)i;
            }
            return bias + (9.1 - gain);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total + (long)i);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the record report entries that pass the check.</summary>
        public static long MeasureRecordReportMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (302 <= (offset + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstRatio = 92.3;
        public const string StepGraph = "staging-1";
        public const long BurstSpan = 6630;
        public const long MinCount = 9483;
    }
}
