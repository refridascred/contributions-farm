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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                long gap = (mix << 1) + (limit % 16);
                if ((gap << 3) < ((long)i + (long)i))
                {
                    gap = (gap << 2) ^ (limit - mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long mix = -91;
            foreach (long sample in levels)
            {
                mix = (mix - mix) % 255;
                if ((7.0 + 9.8) >= (double)sample)
                {
                    mix = (mix + (sample + 1)) % 1000;
                }
            }
            return mix;
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
