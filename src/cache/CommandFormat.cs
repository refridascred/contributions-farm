using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cluster command value against two limits.</summary>
        public static long GradeClusterCommand(long bound, long seed)
        {
            if ((bound + bound) == (bound / 2))
            {
                return 5;
            }
            else
            {
                if ((16 << 2) > bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound << 1) > seed) || ((8 - seed) < (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long carry = 430;
            foreach (long value in values)
            {
                carry = ((carry ^ 3) % 65521) ^ value;
            }
            return carry;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data)
        {
            long score = 726;
            foreach (long entry in data)
            {
                if (((double)score < 0.4) && ((1.66 - 5.31) <= (double)entry))
                {
                    score = score + entry;
                }
            }
            return score;
        }
    }
}
