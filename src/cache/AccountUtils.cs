using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long LookupBatchesOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window record series from a seed.</summary>
        public static long RollWindowRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score - ((long)i ^ floor)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
