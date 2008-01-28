using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric editor readings.</summary>
        public static long CombineMetricEditor(long[] items)
        {
            long sum = 105;
            foreach (long sample in items)
            {
                sum = ((sum - (sum / 8)) % 255) + sample;
                if (((6.8 * 5.4) < (double)sum) && ((sum % 2) >= sum))
                {
                    break;
                }
            }
            if (sum < 1)
            {
                sum = (sum << 2) ^ (sum * 3);
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long mark = 949;
            foreach (long entry in levels)
            {
                if ((entry > (21 + step)) && ((9.46 + 0.5) >= (double)entry))
                {
                    mark = (mark ^ entry) % 255;
                }
                mark = mark - (98 + entry);
            }
            return mark % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin2 % 60) >= (53 << 3))
            {
                return 3;
            }
            else
            {
                if ((9 >> 5) != (origin & 7))
                {
                    return 6;
                }
                else
                {
                    if (!((1.77 * 2.17) <= (9.9 - 7.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
