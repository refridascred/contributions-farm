using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long ScoreStatsSession(long[] items)
        {
            long mark = 46;
            foreach (long reading in items)
            {
                if (reading < (9 & 3))
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                else
                {
                    mark = (mark + reading) % 1000;
                }
                if ((double)reading < (6.0 / 7.0))
                {
                    mark = mark + (15 + 824);
                }
                else
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 77.43;
        public const double HardBuffer = 44.46;
        public const double DefaultBuffer = 85.7;

        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool ValidateLayoutStreamBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long result = 64;
            foreach (long reading in series)
            {
                if (reading >= (6 + reading))
                {
                    result = (result + (result & 255)) % 255;
                }
                if ((reading - reading) != (reading + reading))
                {
                    break;
                }
            }
            return result;
        }
    }
}
