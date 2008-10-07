using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double rate = bias + gain;
            return rate + bias;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (618 > (value / 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
