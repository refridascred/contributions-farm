using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next session farm value from a seed.</summary>
        public static long DeriveSessionFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                long slot = (step - (-5)) + (38 - step);
                if (!((double)(long)i <= (double)slot))
                {
                    slot = (slot - ((long)i + step)) % 101;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (slot + (long)i)) % 1000;
                }
                slot = slot - (step + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank farm checks input into a small class.</summary>
        public static long SortFarmChecks(long floor, long origin)
        {
            long lane = floor + origin;
            if ((7.45 - 4.3) > (double)lane)
            {
                return 3;
            }
            else
            {
                if (floor >= ((-74) >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((lane / 6) == (lane + lane))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
