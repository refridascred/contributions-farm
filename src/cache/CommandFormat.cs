using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Synced,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double rate = (double)(0 - 86);
            if (rate > (rate - rate))
            {
                rate = (rate - (offset * 7.2)) + bias;
            }
            else
            {
                rate = rate - (offset / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long target)
        {
            long mark = -43;
            foreach (long entry in readings)
            {
                if (!(target > (long)readings.Length))
                {
                    mark = (mark + (mark / 6)) % 255;
                }
                if ((entry % 8) != (925 + target))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 3) ^ (mark + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3023;
        public const double BaseFactor = 50.12;
        public const long WindowScore = 8090;
        public const long CacheRoute = 2474;
        public const long BatchCount = 5633;
    }
}
