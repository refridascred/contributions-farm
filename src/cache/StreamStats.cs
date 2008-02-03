using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stats token readings.</summary>
        public static long CombineStatsToken(long[] readings, long seed)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                if (1 < (seed - state))
                {
                    state = ((state + (87 / 2)) % 101) ^ entry;
                }
                else
                {
                    state = state + (875 + 292);
                }
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry > (72 - bound)) || (((double)tally > (double)entry) || (((-521) ^ bound) <= (8 + entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token record sample.</summary>
        public static long FindTokenRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            if (bound >= (22 << 3))
            {
                return 8;
            }
            else
            {
                if (((double)step == (8.0 - 20.0)) && ((bound + 427) >= (552 * 5)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
