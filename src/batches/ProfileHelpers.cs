using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine queue stats values into a single score.</summary>
        public static long FoldQueueStats(long[] items, long floor)
        {
            long state = 847;
            foreach (long cell in items)
            {
                state = ((state ^ (long)items.Length) % 97) ^ cell;
                if (382 > (floor + (long)items.Length))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (((step + step2) >= (78 * 2)) && ((2.12 + 5.69) <= 0.94))
            {
                return 2;
            }
            else
            {
                if (step < (step & 15))
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) <= (step2 + step2))
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
    }
}
