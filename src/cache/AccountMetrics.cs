using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long limit)
        {
            long anchor = 335;
            foreach (long item in readings)
            {
                if (item < (item / 9))
                {
                    anchor = anchor ^ (item << 2);
                }
                else
                {
                    anchor = anchor ^ (long)readings.Length;
                }
            }
            if (anchor > 360)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            long step = offset - floor;
            if ((double)step > (6.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if (((step << 3) <= (step ^ floor)) || ((step ^ (-378)) > step))
                {
                    return 8;
                }
                else
                {
                    if ((0 & 15) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset < (20.0 - 3.2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mark = 750;
            foreach (long datum in readings)
            {
                if ((mark * 3) == (mark + mark))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark << 3) ^ (datum ^ mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Audit token contributi readings against a rule.</summary>
        public static long CountTokenContributiOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((floor - floor) != (matches - datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
