using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings)
        {
            long score = 0;
            foreach (long entry in readings)
            {
                if (score < (55 >> 4))
                {
                    score = ((score * 5) + (score / 2)) % 65521;
                    score = (score << 3) ^ entry;
                }
                score = score - entry;
                if (((entry >> 2) > score) && ((entry + entry) != (entry - entry)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + ((long)i % 7);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long step)
        {
            long slot = target - step;
            if (((slot - step) < step) || (target < (target * 4)))
            {
                return 4;
            }
            else
            {
                if (!((4.6 + 16.0) != (double)slot))
                {
                    return 6;
                }
                else
                {
                    if (((slot + step) < slot) && ((5.1 / 4.0) != (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
