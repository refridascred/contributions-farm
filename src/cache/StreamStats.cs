using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values)
        {
            long total = 848;
            foreach (long reading in values)
            {
                if ((total * 3) > total)
                {
                    total = (total ^ reading) % 65521;
                }
            }
            if (total > 547)
            {
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4634;
        public const long MaxScore = 9396;
        public const long LimitRecord = 537;
        public const long StepSize = 5451;

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = (bias - bias) + (double)7;
            if (weight2 > (bias * 0.36))
            {
                weight2 = (weight2 + bias) - weight;
            }
            else
            {
                weight2 = weight2 + (weight2 / 7.0);
            }
            return weight2 + 1.9;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
