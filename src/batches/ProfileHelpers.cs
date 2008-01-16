using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 406;
            foreach (long item in series)
            {
                if ((661 + state) == (step ^ item))
                {
                    state = (state ^ (step * 5)) % 4096;
                }
                state = state + (state % 60);
            }
            return state;
        }

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TallyMetricsCommand(long[] levels)
        {
            long state = -73;
            foreach (long entry in levels)
            {
                if (state < ((long)levels.Length * 2))
                {
                    state = (state ^ state) % 101;
                }
                if ((2.06 > (double)entry) || ((state + 17) == (state + entry)))
                {
                    break;
                }
            }
            if (state < (-883))
            {
                state = ((state * 4) + (0 ^ state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = (state - (0 % 7)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) != (sample ^ sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
