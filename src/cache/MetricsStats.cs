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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (floor ^ (long)i);
                if (!((floor + floor) > acc))
                {
                    acc = (acc - floor) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if (((7.7 / 4.0) != (double)sample) || (sum <= (36 - 479)))
                {
                    sum = ((sum * 4) + (3 - sum)) % 101;
                }
            }
            return sum;
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
