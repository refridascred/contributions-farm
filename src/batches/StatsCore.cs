using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 5372;
        public const string StepPayload = "legacy";
        public const long CachePayload = 6279;

        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 4;
            foreach (long item in items)
            {
                if ((52 <= (item ^ total)) || ((item % 64) < (920 + item)))
                {
                    total = ((total * 5) + (total % 3)) % 97;
                }
            }
            if (total > 0)
            {
                total = (total ^ 44) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Match up contributi tools samples.</summary>
        public static long CompareContributiToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long SeekCounterBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
