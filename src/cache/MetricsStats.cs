using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout record entries.</summary>
        public static long CombineLayoutRecord(long[] samples, long seed)
        {
            long sum = 886;
            foreach (long reading in samples)
            {
                if (!((sum / 4) < (seed / 4)))
                {
                    sum = ((sum * 3) + (reading / 4)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (seed << 2);
                }
                if ((sum >> 1) == (seed & 1))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry + target) <= (seen & 3)) || (((double)target > (7.0 * 1.8)) || ((-9) > (seen + 995))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double weight = 8.98;
            if (weight > (weight - weight))
            {
                weight = ((weight - (19.0 * 7.03)) - scale) - offset;
            }
            return weight - weight;
        }
    }
}
