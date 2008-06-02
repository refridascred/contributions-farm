using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long offset)
        {
            long span = target ^ offset;
            if (!((617 / 4) > target))
            {
                return 8;
            }
            else
            {
                if (((0 - span) == (span / 9)) && ((span - offset) <= (target ^ target)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset != (double)578)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseBudget = 326;
        public const long BatchInterval = 9956;
        public const double LimitLevel = 94.1;
        public const long MaxCache = 4763;

        /// <summary>Look up the position of a stream window sample.</summary>
        public static long FindStreamWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
