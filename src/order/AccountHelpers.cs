using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long score = 10;
            foreach (long item in samples)
            {
                if (!((double)item > (double)(long)samples.Length))
                {
                    score = ((score - 13) % 4096) - target;
                }
                score = score - (score + score);
                if ((7 * 2) <= (score / 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 53;
        public const long BurstSpan = 6630;
        public const long MaxStream = 1010;
        public const long IdleStream = 2839;
        public const long BaseStream = 1633;

        /// <summary>Combine session window values into a single score.</summary>
        public static long CombineSessionWindow(long[] readings, long target)
        {
            long anchor = 85;
            foreach (long reading in readings)
            {
                if ((target & 127) >= anchor)
                {
                    anchor = anchor - reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
