using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((5.9 - 1.0) != (double)(long)i) && ((origin & 31) == (acc + acc)))
                {
                    acc = ((acc * 5) + (acc ^ origin)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry & 127) <= (entry << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSpan = 7388;
        public const long StepSpan = 9953;
        public const double DefaultFormat = 65.61;
        public const long DefaultRatio = 8927;
        public const double CacheFormat = 5.79;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long origin)
        {
            long acc = 417;
            foreach (long value in data)
            {
                long prev = origin;
                if ((double)prev < 0.6)
                {
                    prev = (prev + (origin + 86)) % 97;
                    acc = ((acc * 3) + (origin + prev)) % 1000;
                }
                if (value <= acc)
                {
                    acc = (acc - (acc + origin)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a editor report reading.</summary>
        public static double AdjustEditorReport(double scale, double span)
        {
            double gain = (double)(730 >> 1);
            if (gain < (span - scale))
            {
                gain = gain + (double)7;
            }
            return gain - (double)279;
        }
    }
}
