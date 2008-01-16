using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double ratio = (gain + offset) + (gain - offset);
            return ratio - (ratio + ratio);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "alpha-1";
        public const long CacheChecks = 1180;
        public const long BurstDepth = 2353;
        public const long RetryChecks = 5535;
        public const long BatchChecks = 2904;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)offset >= (2.29 * 8.0)))
                {
                    result = ((result << 2) ^ (result + offset)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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
