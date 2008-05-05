using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (19.0 < (double)sum)
                {
                    sum = sum - (sum + origin);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long BucketTokenLayout(long seed, long step)
        {
            if ((double)step == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed & 7) == (40 + step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
