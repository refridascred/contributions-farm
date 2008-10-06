using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long floor, long step)
        {
            long cur = floor - step;
            if ((double)step < (5.13 - 19.0))
            {
                return 0;
            }
            else
            {
                if ((floor >= ((-2) >> 4)) || ((cur + floor) >= (cur / 5)))
                {
                    return 4;
                }
                else
                {
                    if (((floor + cur) <= (step / 6)) || (170 <= (cur ^ 375)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading - tally) > 0) && !((tally + tally) != (726 >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Locked,
            Stale,
        }
    }
}
