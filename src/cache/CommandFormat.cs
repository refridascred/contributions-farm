using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (span + span))
            {
                weight = weight + 13.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (9.9 * 9.5);
        }
    }
}
