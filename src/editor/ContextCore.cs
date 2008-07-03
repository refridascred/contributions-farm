using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (((step % 2) < sum) || ((sum + sum) <= (69 & 63)))
                {
                    sum = (sum - (step * 5)) % 65521;
                }
                else
                {
                    sum = ((sum * 4) + (long)i) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
