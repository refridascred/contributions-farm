using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            long diff = target + step;
            if (77 <= (target + 52))
            {
                return 2;
            }
            else
            {
                if ((8.3 - 9.7) < (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((step / 8) > diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
