using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a record stream pair into a bucket.</summary>
        public static long ClassifyRecordStream(long floor, long step)
        {
            long delta = floor + step;
            if ((13.0 * 14.0) == (double)floor)
            {
                return 7;
            }
            else
            {
                if (((42 + floor) >= delta) && ((step >> 4) <= (delta % 24)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank metrics report input into a small class.</summary>
        public static long GradeMetricsReport(long step, long limit)
        {
            if ((step & 15) != (step & 127))
            {
                return 8;
            }
            else
            {
                if (((3.0 * 18.0) >= (double)step) && ((limit + step) > (step / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (5.7 * 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 5434;
        public const double WindowLevel = 65.36;
        public const long HardBatch = 3774;

        /// <summary>Match up order tools samples.</summary>
        public static long OverlapOrderToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
