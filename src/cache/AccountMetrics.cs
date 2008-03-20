using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long bound)
        {
            long span = target - bound;
            if ((span ^ bound) == (span >> 1))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) == (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long limit)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                if (!((double)limit >= (4.0 * 12.0)))
                {
                    total = ((total << 2) ^ (sample / 9)) % 101;
                }
                total = (total ^ (sample << 3)) % 1000;
            }
            if (total > 26)
            {
                total = (total ^ (total >> 4)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 95;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample < (total >> 1)) || ((sample + sample) != (total << 3)))
                {
                    total = ((total * 3) + (sample - total)) % 255;
                }
                if (((16.0 + 12.0) >= (double)total) && ((sample << 3) >= (sample + total)))
                {
                    total = (total - total) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "cached";
        public const long LimitNotes = 3397;
        public const string SoftSpan = "local";
        public const long IdleNotes = 2305;
        public const double BurstFactor = 17.34;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long total = 8;
            foreach (long item in data)
            {
                total = (((total ^ (total - total)) % 97) ^ item) - floor;
            }
            return total % 1000;
        }
    }
}
