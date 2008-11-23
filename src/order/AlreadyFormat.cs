using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long offset)
        {
            if (((offset + 62) > bound) && ((32 >> 2) == (bound + offset)))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset >> 5))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound >= (1.01 * 9.63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 10) > offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1.1 / 9.0) <= (double)floor)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value >= (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long origin)
        {
            long result = -375;
            foreach (long item in readings)
            {
                result = (result - origin) - item;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
