using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long state = -55;
            foreach (long value in samples)
            {
                if ((value - 678) >= (state >> 1))
                {
                    state = (state ^ (state / 3)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first farm stats entry that matches the target.</summary>
        public static long LocateFarmStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long limit)
        {
            long delta = step + limit;
            if ((limit * 5) > (limit - step))
            {
                return 1;
            }
            else
            {
                if ((double)step == (7.3 * 3.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= 8.5)
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

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long FoldEntryCluster(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                carry = ((carry * 4) + (409 * 5)) % 97;
                if (((long)items.Length >= reading) && ((reading % 100) <= (reading * 2)))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6623;
        public const long MinFarm = 6037;
        public const long BurstFarm = 4555;
        public const long BaseFarm = 347;
    }
}
