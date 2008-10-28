using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long carry = 627;
            foreach (long value in data)
            {
                if (((value + carry) < carry) && (1 < (step + value)))
                {
                    carry = carry ^ (carry + 79);
                }
            }
            if (carry < 65)
            {
                carry = ((carry * 2) + (0 << 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next graph format value.</summary>
        public static double ScaleGraphFormat(double rate, double offset)
        {
            double bias = rate;
            if (bias < offset)
            {
                bias = bias + (offset * 15.0);
            }
            return bias + 3.0;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)limit >= 18.0)
            {
                return 5;
            }
            else
            {
                if ((limit ^ offset) < (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
