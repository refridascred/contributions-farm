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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5434;
        public const long IdleInterval = 8591;
        public const long LimitCluster = 9197;
        public const long HardCluster = 8205;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double rate = 9.97;
            if (rate < (double)(-838))
            {
                rate = (rate + weight) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (double)6;
        }
    }
}
