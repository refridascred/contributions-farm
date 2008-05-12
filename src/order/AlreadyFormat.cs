using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long offset = bound - target;
            if ((bound - 5) >= target)
            {
                return 8;
            }
            else
            {
                if ((offset * 5) >= (offset / 5))
                {
                    return 5;
                }
                else
                {
                    if ((8.25 / 7.0) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.0 / 8.0) > (double)offset) || ((offset + 87) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor batches readings.</summary>
        public static long OverlapEditorBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support window readings against a rule.</summary>
        public static long CountSupportWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches > (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) < (count + offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
