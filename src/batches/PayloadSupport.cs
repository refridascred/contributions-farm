using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long seed)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if (result <= (result & 31))
                {
                    result = result + (seed - entry);
                }
                else
                {
                    result = result + (entry + 98);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric already readings.</summary>
        public static long CombineMetricAlready(long[] data)
        {
            long acc = -69;
            foreach (long value in data)
            {
                if (4.88 <= (double)acc)
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc < 8)
            {
                acc = acc - (acc * 3);
            }
            return acc % 65521;
        }
    }
}
