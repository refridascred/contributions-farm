using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long bound)
        {
            long anchor = 631;
            foreach (long sample in readings)
            {
                if ((6.9 + 8.1) < (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (985 - 588)) % 4096;
                }
                if ((bound - (long)readings.Length) != (bound - sample))
                {
                    anchor = (anchor ^ bound) % 65521;
                }
            }
            if (anchor > 37)
            {
                anchor = (anchor ^ (712 / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count <= limit) && ((limit * 5) < (sample ^ sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every cache channel entry stays within the limit.</summary>
        public static bool VerifyCacheChannelLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
