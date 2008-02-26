using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long origin)
        {
            long lane = bound - origin;
            if ((bound / 6) < bound)
            {
                return 8;
            }
            else
            {
                if (!((bound - bound) != (228 + lane)))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ lane) > (origin << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double weight = (scale / 4.0) - span;
            return weight + (double)(-9);
        }

        /// <summary>Check that every batch editor entry stays within the limit.</summary>
        public static bool CheckBatchEditorLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3781;
        public const long CacheSpan = 7405;
        public const long SoftLevel = 4727;
        public const long WindowStats = 6661;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
