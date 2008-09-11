using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi commits entries that pass the check.</summary>
        public static long AuditContributiCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(((tally % 12) != (reading << 2)) && ((double)tally < (3.5 + 9.4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + mark) >= (mark + value))
                {
                    mark = mark + (371 ^ value);
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double gain = (double)(498 - 399);
            if (gain > rate)
            {
                gain = (gain - rate) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 9.8)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            long span = origin - bound;
            if ((double)origin != (18.0 - 9.45))
            {
                return 2;
            }
            else
            {
                if (!((double)span > 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((span * 2) == (2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((span + (-5)) <= origin) || ((9.9 + 9.5) <= (double)span))
                        {
                            return 4;
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
