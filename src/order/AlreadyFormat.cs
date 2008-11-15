using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate layout queue samples.</summary>
        public static long ScoreLayoutQueue(long[] data, long bound)
        {
            long sum = 98;
            foreach (long item in data)
            {
                sum = (((sum + (sum & 15)) % 65521) ^ item) + bound;
            }
            return sum;
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long StepReportAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((floor + limit) < (floor - floor))
            {
                return 3;
            }
            else
            {
                if (!((double)limit <= 4.62))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 - 7.49) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a route context reading by value.</summary>
        public static long SeekRouteContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
