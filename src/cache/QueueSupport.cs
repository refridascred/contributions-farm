using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long step)
        {
            if ((seed - step) <= (-1))
            {
                return 1;
            }
            else
            {
                if (!((double)seed <= (0.07 - 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step * 2) >= step)
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell * 4) == (cell + cell))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSize = 3865;
        public const long StepSchema = 3869;
        public const long MinLevel = 3917;
    }
}
