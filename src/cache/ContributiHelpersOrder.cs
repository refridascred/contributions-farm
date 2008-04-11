using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long limit, long limit2)
        {
            if ((limit2 - 84) < (limit2 + limit2))
            {
                return 5;
            }
            else
            {
                if ((limit % 3) < (limit2 ^ limit2))
                {
                    return 3;
                }
                else
                {
                    if ((91 + limit2) > (0 - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit2 <= (1.65 - 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 394;
            foreach (long item in readings)
            {
                if ((result + offset) >= (long)readings.Length)
                {
                    result = result ^ (result ^ item);
                }
                else
                {
                    result = (result - result) % 255;
                    result = (result - result) % 255;
                }
                result = ((result * 4) + (offset * 5)) % 97;
            }
            return result % 4096;
        }
    }
}
