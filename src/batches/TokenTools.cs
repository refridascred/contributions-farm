using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long offset)
        {
            long step = target ^ offset;
            if ((target >> 3) == (step / 3))
            {
                return 4;
            }
            else
            {
                if (!((offset & 3) == (target >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((target + offset) != (step / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >= 6) || ((2.03 - 4.24) != (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Synced,
            Done,
            Failed,
            Locked,
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
