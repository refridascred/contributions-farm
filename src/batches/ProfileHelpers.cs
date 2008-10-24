using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long DigestFarmRecord(long[] samples, long offset)
        {
            long state = 12;
            foreach (long cell in samples)
            {
                state = ((state - offset) % 255) - cell;
            }
            if (state > 866)
            {
                state = state ^ (-904);
            }
            return state % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 98.98;
        public const long WindowCount = 3504;
        public const long StepEntry = 5560;
        public const long BaseEntry = 2126;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long MeasureOrderContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.35 / 7.0) > (double)entry) || ((entry + 66) > (entry + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stats already values into a single score.</summary>
        public static long ScoreStatsAlready(long[] data, long seed)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                mark = ((mark ^ (seed - 672)) % 101) ^ reading;
                mark = ((mark << 3) ^ seed) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long anchor = 78;
            foreach (long item in series)
            {
                anchor = ((anchor ^ (57 << 3)) + item) + limit;
            }
            return anchor;
        }
    }
}
