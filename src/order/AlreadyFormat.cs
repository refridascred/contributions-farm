using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batch githubfarm readings against a rule.</summary>
        public static long MeasureBatchGithubfarmHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 1) >= (reading + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count the record metrics entries that pass the check.</summary>
        public static long MeasureRecordMetricsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a farm stream pair into a bucket.</summary>
        public static long GradeFarmStream(long limit, long floor)
        {
            long offset = limit + floor;
            if (!((3.84 + 2.6) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((10.0 - 2.2) >= (double)limit) || (limit < (limit * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (anchor - anchor);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
