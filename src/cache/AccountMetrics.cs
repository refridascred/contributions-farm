using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool VerifyEntryWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)carry >= (0.09 * 7.9))
                {
                    carry = ((carry * 4) + (carry ^ bound)) % 101;
                    continue;
                }
                if ((7.55 * 4.9) == (double)bound)
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long floor)
        {
            long slot = bound - floor;
            if ((slot - bound) > (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) != (bound + bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = (score - 99) % 101;
                if ((19.0 * 7.7) > 4.0)
                {
                    score = score + value;
                }
                if (((score - 63) == (score + score)) && (value <= (value >> 5)))
                {
                    break;
                }
            }
            if (score < 977)
            {
                score = (score - ((-2) << 2)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long step, long origin)
        {
            long lane = step ^ origin;
            if ((origin + step) <= step)
            {
                return 8;
            }
            else
            {
                if ((lane / 6) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 4) >= (lane + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
