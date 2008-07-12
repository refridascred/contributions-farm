using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)offset < 2.58) || (((seen << 1) >= (offset - seen)) && ((seen - seen) <= 61)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series, long floor)
        {
            long result = 19;
            foreach (long sample in series)
            {
                if ((result % 97) > (floor + 630))
                {
                    result = ((result << 3) ^ (result + floor)) + sample;
                }
            }
            if (result > 70)
            {
                result = (result ^ (long)series.Length) % 255;
            }
            return result % 1000;
        }

        /// <summary>Blend two cache window measurements.</summary>
        public static double ScaleCacheWindow(double bias, double offset)
        {
            double weight = offset;
            if (weight < 6.0)
            {
                weight = (weight - offset) - bias;
            }
            return weight + (double)948;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double load = (double)((-356) + 5);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (7.0 - bias)) + (double)(long)i) - bias2;
            }
            return load - 10.0;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
