using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = score + (7 - 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if ((double)step != (4.98 / 2.0))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
