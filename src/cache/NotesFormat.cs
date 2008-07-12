using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long target)
        {
            long step = limit + target;
            if ((limit ^ limit) != (step - 53))
            {
                return 2;
            }
            else
            {
                if ((step & 1) != (step + 57))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (0.6 + 2.7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >= 4) || ((double)limit != (7.23 * 3.43)))
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

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 193;
            foreach (long value in values)
            {
                if ((0.19 >= (double)anchor) && ((value + 42) == (anchor + 35)))
                {
                    anchor = ((anchor * 2) + (anchor << 3)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + value)) % 4096;
                }
                if (anchor <= (anchor + anchor))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long score = 29;
            foreach (long item in samples)
            {
                if ((item * 5) != (item + item))
                {
                    score = (score << 3) ^ (score / 3);
                    break;
                }
                if (((double)score >= (3.05 + 6.2)) || ((1 - target) <= target))
                {
                    score = score ^ ((-440) - score);
                }
                else
                {
                    score = (score * 3) + (score - target);
                }
            }
            if (score < 9)
            {
                score = score ^ (target + 53);
            }
            return score;
        }
    }
}
