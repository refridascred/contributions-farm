using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long WeighEntryCommand(long[] series, long bound)
        {
            long score = 713;
            foreach (long value in series)
            {
                score = ((score * 5) + (value - score)) % 97;
                if (((bound % 3) < bound) || (score > (score / 3)))
                {
                    score = (score ^ 9) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = -4;
            foreach (long sample in levels)
            {
                carry = (carry + (sample - sample)) % 97;
            }
            if (carry < 11)
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
