using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long limit2)
        {
            if ((limit2 << 3) < (limit2 + limit))
            {
                return 3;
            }
            else
            {
                if ((limit2 - limit2) > limit2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long MeasureTokenEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) <= (reading << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 5745;
        public const long DefaultSpan = 2931;
        public const long CacheReport = 380;

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
