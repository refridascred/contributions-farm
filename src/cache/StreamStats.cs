using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count notes command pairs that satisfy a relation.</summary>
        public static long CompareNotesCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)bound == (3.31 / 5.0))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseFactor = 14.47;
        public const double BurstTimeout = 39.5;
        public const double BaseCount = 36.54;
        public const double DefaultScore = 78.73;
    }
}
