using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long edge = offset - floor;
            if ((floor / 5) >= edge)
            {
                return 8;
            }
            else
            {
                if (1 >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((6.0 - 7.32) >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) > (edge ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitBudget = 92.52;
        public const double WindowCache = 72.9;
        public const long StepSpan = 5571;
        public const long DefaultSpan = 2965;

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
