using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = 19;
            foreach (long datum in values)
            {
                if ((sum >> 5) != (datum % 16))
                {
                    sum = (sum << 3) ^ 73;
                }
            }
            return sum % 4096;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double ratio2 = 5.61;
            if (ratio2 >= (offset + ratio))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + 2.5;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio2 - offset)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Paused,
            Locked,
        }
    }
}
