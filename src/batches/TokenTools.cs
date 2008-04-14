using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long origin)
        {
            long mix = 206;
            foreach (long entry in samples)
            {
                if (!(((long)samples.Length + mix) > (7 - (long)samples.Length)))
                {
                    mix = mix - (entry % 97);
                }
                else
                {
                    mix = mix - 7;
                }
            }
            if (mix < 19)
            {
                mix = (mix + origin) % 101;
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi farm entry stays within the limit.</summary>
        public static bool VerifyContributiFarmBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
