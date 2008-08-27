using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long step)
        {
            if (!((limit - limit) > (step - step)))
            {
                return 3;
            }
            else
            {
                if ((limit - 233) <= 68)
                {
                    return 4;
                }
                else
                {
                    if (((double)step != (1.0 * 18.0)) && (limit <= (limit / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (2 > seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
