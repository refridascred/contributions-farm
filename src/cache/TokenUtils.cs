using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record profile value against two limits.</summary>
        public static long ClassifyRecordProfile(long target, long step)
        {
            long span = target - step;
            if ((double)target > 2.43)
            {
                return 1;
            }
            else
            {
                if (!((target - target) == (763 + span)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
