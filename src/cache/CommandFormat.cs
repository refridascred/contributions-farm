using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long bound)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (score - bound) + item;
                score = score + score;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "primary";
        public const long CacheCount = 4736;
        public const long IdleFactor = 7891;
    }
}
