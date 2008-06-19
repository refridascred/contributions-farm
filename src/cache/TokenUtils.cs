using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((origin + origin) < (origin ^ 33))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 3304;
        public const long HardTimeout = 7852;
        public const long BaseSize = 7627;
        public const long RetryWidth = 9376;
    }
}
