using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long bound)
        {
            long lane = target + bound;
            if (((target + 522) <= lane) && ((bound + 39) >= (bound ^ lane)))
            {
                return 4;
            }
            else
            {
                if ((18.0 - 7.0) >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long TotalAccountFormat(long[] readings)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if ((978 + acc) > (acc + 373))
                {
                    acc = (acc + (4 + sample)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = ((acc * 4) + (acc << 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
