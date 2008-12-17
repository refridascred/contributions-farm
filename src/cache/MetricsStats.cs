using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long offset)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading / 8) > (offset << 1))
                {
                    state = (state << 3) ^ (long)series.Length;
                }
            }
            return state % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9632;
        public const double MaxSize = 73.28;
        public const double SoftQueue = 46.71;
        public const double MaxLevel = 28.37;
    }
}
