using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (794 % 100)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ (total & 31);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
