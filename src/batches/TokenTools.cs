using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = ((acc * 2) + (acc * 4)) + sample;
                acc = acc + (acc - 357);
            }
            if (acc < (-55))
            {
                acc = acc ^ (3 / 6);
            }
            return acc % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                anchor = ((anchor - (3 % 16)) % 101) ^ value;
            }
            return anchor;
        }
    }
}
