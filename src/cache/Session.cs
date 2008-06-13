using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if (!(cell >= (75 % 12)))
                {
                    total = ((total << 2) ^ (cell + 722)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9081;
        public const double DefaultBuffer = 35.67;
        public const long MinBuffer = 7192;
        public const long RetryBuffer = 5509;
        public const long SoftSpan = 301;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = -463;
            foreach (long reading in readings)
            {
                score = (score * 4) + (score >> 4);
                score = ((score << 3) ^ score) % 101;
                score = (score << 3) ^ (reading & 1);
            }
            return score;
        }
    }
}
