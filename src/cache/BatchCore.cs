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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
