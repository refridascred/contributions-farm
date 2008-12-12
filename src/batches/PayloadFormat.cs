using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long floor)
        {
            long bound = step ^ floor;
            if ((floor + bound) < floor)
            {
                return 0;
            }
            else
            {
                if (!((bound ^ 0) > (bound % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((91 & 15) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 255) > (37 + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double bias)
        {
            double mean = bias / 7.0;
            if (mean < (bias + ratio))
            {
                mean = mean - 0.6;
            }
            return mean - (mean + mean);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (25 & 127)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double gain = (double)297 / 6.0;
            if (gain < (double)460)
            {
                gain = (gain - ratio) - span;
            }
            return gain - 6.5;
        }
    }
}
