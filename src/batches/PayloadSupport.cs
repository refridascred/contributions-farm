using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if ((sum * 4) < (sum % 10))
                {
                    sum = (((sum << 2) ^ sample) % 101) + step;
                }
                sum = (sum - (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a context stream value against two limits.</summary>
        public static long ClassifyContextStream(long target, long step)
        {
            if (((step % 5) <= (step + 34)) && ((double)step < (5.9 + 3.6)))
            {
                return 8;
            }
            else
            {
                if (step >= target)
                {
                    return 1;
                }
                else
                {
                    if ((58 << 2) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
