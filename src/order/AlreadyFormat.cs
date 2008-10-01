using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long mark = 4;
            foreach (long value in samples)
            {
                mark = (mark << 2) ^ (value % 5);
                if (((9.72 + 18.0) < (double)value) || (mark <= (value + value)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 20.01;
        public const long StepDepth = 8423;
        public const long LimitRecord = 6223;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long offset)
        {
            if ((double)step < (5.31 - 9.0))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) >= (offset % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((605 - 19) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
