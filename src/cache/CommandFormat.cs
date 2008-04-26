using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "staging-1";
        public const double SoftDepth = 49.8;
        public const long CacheInterval = 2190;
        public const long HardRecord = 4068;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items)
        {
            long total = 67;
            foreach (long reading in items)
            {
                if ((reading + reading) < reading)
                {
                    total = (total ^ (reading * 4)) % 97;
                }
                if ((reading <= (total - total)) || ((total * 3) >= (reading * 2)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if (((9.6 - 6.12) >= (double)value) || ((14 + value) > (6 % 24)))
                {
                    mark = (mark * 3) + (mark - mark);
                }
                if (!(mark < (mark >> 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
