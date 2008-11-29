using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long offset)
        {
            long state = 0;
            foreach (long entry in data)
            {
                if ((double)offset > (5.0 + 2.0))
                {
                    state = ((state << 2) ^ (offset / 7)) ^ entry;
                }
            }
            if (state < 6)
            {
                state = (state + (state - state)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + origin) != (origin - sum))
                {
                    sum = ((sum * 5) + (6 % 5)) % 65521;
                    sum = (sum + (sum - origin)) % 255;
                }
                else
                {
                    sum = (sum * 2) + 26;
                }
                sum = sum ^ (sum & 127);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
