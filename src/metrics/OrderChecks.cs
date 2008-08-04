using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long seed)
        {
            long total = 809;
            foreach (long value in readings)
            {
                if (((total & 7) != (26 / 3)) && (value >= seed))
                {
                    total = ((total << 3) ^ (total & 15)) % 65521;
                }
                if ((120 + 27) > (value - value))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total - (seed + total);
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1344;
        public const long SoftContributi = 701;
        public const long StepContributi = 9796;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
