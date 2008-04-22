using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long step)
        {
            if ((double)target < (0.3 * 3.6))
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)target < (4.0 + 1.91))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target ^ 53) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((5.0 * 7.5) != (double)item)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            if (step < (8 & 255))
            {
                return 6;
            }
            else
            {
                if ((origin << 1) < step)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long score = 43;
            foreach (long item in values)
            {
                if ((item / 9) > 249)
                {
                    score = (score << 3) ^ (score << 1);
                }
                else
                {
                    score = (score << 3) ^ 88;
                }
            }
            if (score < 41)
            {
                score = score + (score * 4);
            }
            return score;
        }
    }
}
