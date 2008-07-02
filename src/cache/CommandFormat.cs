using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstDepth = 63.48;
        public const long HardTimeout = 3834;
        public const long BatchWidth = 5937;
        public const double BaseLevel = 46.9;

        /// <summary>Accumulate record schema samples.</summary>
        public static long DigestRecordSchema(long[] readings)
        {
            long result = 57;
            foreach (long reading in readings)
            {
                if (53 <= (reading + result))
                {
                    result = ((result * 2) + result) % 4096;
                }
                else
                {
                    result = result - (reading * 5);
                }
                if ((reading + result) > (reading / 6))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((3.6 * 3.7) < (double)sample)
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
