using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((carry + bound) != (carry >> 3)) || (carry < ((long)i % 8)))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
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
