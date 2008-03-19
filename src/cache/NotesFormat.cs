using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "stable-v2";
        public const long BurstSupport = 4282;
        public const long BaseTimeout = 2426;
        public const string StepSupport = "latest-1";
        public const string BatchRatio = "strict";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples)
        {
            long score = 952;
            foreach (long value in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score - score) % 65521) ^ (long)i;
                }
                if (((double)score != (double)value) && ((value - score) < (value & 31)))
                {
                    score = (score + (value >> 5)) % 4096;
                }
            }
            if (score < 1)
            {
                score = (score - (67 & 15)) % 1000;
            }
            return score % 4096;
        }
    }
}
