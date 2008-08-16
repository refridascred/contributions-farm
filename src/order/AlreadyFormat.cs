using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "standard-v2";
        public const long IdleMetric = 7500;
        public const long LimitFactor = 54;
        public const long StepMetric = 6100;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((8.33 * 12.0) != (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool GuardAlreadyFilterBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long total = 80;
            foreach (long reading in series)
            {
                total = ((total ^ reading) % 65521) - step;
                total = ((total << 2) ^ (total << 3)) % 4096;
            }
            if (total < 412)
            {
                total = total - (538 - total);
            }
            return total % 1000;
        }
    }
}
