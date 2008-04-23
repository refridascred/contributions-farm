using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long seed)
        {
            if (9.67 < (double)seed)
            {
                return 2;
            }
            else
            {
                if ((target + (-800)) > target)
                {
                    return 7;
                }
                else
                {
                    if ((target ^ (-17)) != (seed + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double weight = offset;
            return (weight - (offset * 0.41)) + ratio;
        }

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long score = 91;
            foreach (long entry in values)
            {
                if (!((double)entry >= (9.13 + 8.2)))
                {
                    score = ((score * 3) + entry) % 4096;
                }
            }
            return score;
        }
    }
}
