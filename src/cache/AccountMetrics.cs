using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long step)
        {
            long lane = origin ^ step;
            if ((origin - lane) >= (lane / 7))
            {
                return 4;
            }
            else
            {
                if ((double)lane <= (4.9 * 9.0))
                {
                    return 7;
                }
                else
                {
                    if (((origin << 2) < (lane + step)) && ((step - step) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool CheckAccountSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double weight = 2.69 - floor;
            if (weight < (floor * 3.8))
            {
                weight = (weight + (double)45) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (2.0 + 0.25)) + (double)(long)i;
            }
            return weight + (weight * 4.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((double)seed <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (8 <= (979 + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long RollQueueFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
