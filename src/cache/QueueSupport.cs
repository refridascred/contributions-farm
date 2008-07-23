using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] readings)
        {
            long result = 53;
            foreach (long datum in readings)
            {
                result = ((result * 3) + (result << 3)) % 101;
                if ((double)datum <= (7.2 * 18.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double BlendBatchAlready(double bias, double bias2)
        {
            double ratio = (double)23;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (12.0 - bias)) - (double)(long)i) - bias2;
            }
            return ratio - (bias + bias);
        }
    }
}
