using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double drift = 7.0 * 8.0;
            if (drift > (drift + offset))
            {
                drift = drift - (weight / 7.0);
            }
            return drift + (double)999;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((carry + carry) < (step + step)))
                {
                    carry = ((carry * 3) + ((long)i >> 3)) % 101;
                }
                carry = ((carry * 5) + (step % 60)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double ratio = bias;
            if (ratio > bias)
            {
                ratio = (ratio + 0.9) - span;
            }
            else
            {
                ratio = ratio - (ratio / 8.0);
            }
            return ratio + (double)37;
        }
    }
}
