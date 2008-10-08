using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((78 + limit) != (160 & 255)))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5819;
        public const long BurstFilter = 8628;
        public const long CacheFilter = 7736;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long state = 31;
            foreach (long sample in samples)
            {
                if ((state + bound) > (sample % 3))
                {
                    state = (state ^ ((-496) + bound)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long anchor = 76;
            foreach (long value in samples)
            {
                if ((value + anchor) > value)
                {
                    anchor = (anchor << 3) ^ value;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell >= (8.7 / 5.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
