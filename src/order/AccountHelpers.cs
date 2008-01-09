using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ (step / 3)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (offset / 9.0))
            {
                mean = mean - (ratio / 6.0);
            }
            else
            {
                mean = mean - (ratio * 6.4);
            }
            return mean - 7.65;
        }

        /// <summary>Roll a counter order counter forward.</summary>
        public static long IterateCounterOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                long diff = (total & 127) + seed;
                if ((diff - 8) > (long)i)
                {
                    diff = ((diff * 5) + seed) % 101;
                    total = ((total * 5) + (long)i) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double bias = (floor * 0.7) * 4.73;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (bias / 8.0)) - (double)(long)i) - scale;
            }
            return bias - floor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Failed,
            Closed,
        }
    }
}
