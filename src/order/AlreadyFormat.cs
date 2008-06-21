using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                if (score <= (cell & 63))
                {
                    score = ((score * 4) + (cell << 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double load = (double)65;
            if (load <= (double)38)
            {
                load = (load + (double)291) - gain;
            }
            else
            {
                load = load + (bias * 19.0);
            }
            return load + (double)21;
        }

        /// <summary>Find the first cache batch entry that matches the target.</summary>
        public static long SeekCacheBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long TallyFilterBatchHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) > (floor >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
