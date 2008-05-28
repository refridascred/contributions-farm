using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count / 4) < (cell + 970)) && !((5 - count) <= (34 >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long total = 465;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ total))
                {
                    total = ((total * 3) + cell) % 97;
                }
                if ((cell >> 4) <= (cell - cell))
                {
                    total = (total + (3 % 16)) % 1000;
                }
            }
            if (total < 40)
            {
                total = ((total << 2) ^ (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleWidth = 1742;
        public const double BurstAlready = 31.27;
        public const long HardScore = 1546;
        public const long MaxAlready = 9641;
        public const long StepAlready = 9357;
    }
}
