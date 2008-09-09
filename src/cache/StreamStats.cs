using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > rate)
            {
                ratio = ratio + (6.3 / 9.0);
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio - (double)43;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 243;
            foreach (long sample in items)
            {
                if (((double)6 >= (double)carry) && ((sample << 3) <= (carry + sample)))
                {
                    carry = (carry ^ sample) % 97;
                }
                else
                {
                    carry = (carry ^ ((-447) % 100)) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
