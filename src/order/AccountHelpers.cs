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

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double floor)
        {
            double load = (double)(150 + 3);
            if (load >= (double)50)
            {
                load = load + (double)94;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((401 << 3) < (matches - (-8)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
