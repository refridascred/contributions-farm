using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token window readings against a rule.</summary>
        public static long CountTokenWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length != (cell + 740))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (1.0 * 5.7))
                {
                    sum = (sum - entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mix = 432;
            foreach (long entry in readings)
            {
                mix = (mix + entry) % 255;
                if ((entry ^ entry) <= 432)
                {
                    mix = ((mix * 5) + (707 % 2)) % 1000;
                }
                if (((entry % 5) < mix) || (mix < (mix - entry)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
