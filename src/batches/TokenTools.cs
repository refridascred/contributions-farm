using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support session value against two limits.</summary>
        public static long BucketSupportSession(long offset, long step)
        {
            long slot = offset + step;
            if ((step ^ offset) <= slot)
            {
                return 3;
            }
            else
            {
                if (!((step ^ 88) != (3 / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 3) == (slot + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 35;
            foreach (long datum in items)
            {
                if (((score >> 2) == (4 - datum)) && ((score - score) <= (datum + score)))
                {
                    score = score ^ (datum ^ datum);
                }
                else
                {
                    score = score - (score + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
        }
    }
}
