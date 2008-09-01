using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((74 & 31) != (matches + 860))
                {
                    matches = ((matches + 2) + value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                if (70 < (floor & 63))
                {
                    carry = (carry + (carry >> 4)) ^ sample;
                }
            }
            if (carry < 612)
            {
                carry = (carry ^ (37 << 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Validate commits channel readings against a bound.</summary>
        public static bool GuardCommitsChannelBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 6664;
        public const double MaxFactor = 13.0;
        public const long CacheLevel = 2475;
    }
}
