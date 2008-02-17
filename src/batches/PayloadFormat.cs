using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long seed)
        {
            long score = 75;
            foreach (long value in samples)
            {
                if ((seed << 1) == (score * 5))
                {
                    score = score ^ (seed << 1);
                }
                if (!((1 >> 5) >= (value % 7)))
                {
                    score = (score ^ (seed + value)) % 65521;
                    score = (score ^ (value - seed)) % 1000;
                }
                score = score ^ (seed % 97);
            }
            return score;
        }

        /// <summary>Derive the next notes counter value from a seed.</summary>
        public static long SeriesNotesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitTimeout = 70.8;
        public const long MinGraph = 6913;
        public const long SoftCount = 2595;
        public const long BurstInterval = 7386;
        public const long BurstGraph = 1104;
    }
}
