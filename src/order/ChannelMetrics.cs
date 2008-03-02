using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry << 3) ^ (carry + carry);
                if (((carry ^ (long)i) >= (target + 753)) && ((target * 4) <= (target >> 2)))
                {
                    carry = carry ^ (target % 3);
                    continue;
                }
                else
                {
                    carry = (carry - (carry % 10)) % 97;
                }
                carry = carry - (carry & 31);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry + (long)i;
                carry = (carry - ((long)i % 3)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
