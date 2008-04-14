using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long seed)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if ((mix + mix) >= (671 / 3))
                {
                    mix = ((mix << 2) ^ (item ^ item)) % 97;
                    mix = mix ^ seed;
                }
                else
                {
                    mix = (mix << 2) ^ (item & 127);
                }
                if (!(((seed >> 5) > (seed - seed)) && (seed < 6)))
                {
                    mix = mix ^ (7 % 3);
                    mix = (mix + (mix - mix)) % 101;
                }
                if ((item + seed) == ((-7) + mix))
                {
                    mix = mix + (seed + item);
                }
                else
                {
                    mix = ((mix * 3) + (item << 2)) % 101;
                }
            }
            if (mix < 9)
            {
                mix = (mix - (mix + seed)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 0;
            foreach (long cell in data)
            {
                sum = sum ^ cell;
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + 17) > floor)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
