using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8378;
        public const long BatchScore = 4430;
        public const long WindowWidth = 7764;
        public const long DefaultMetric = 400;

        /// <summary>Compare every pair of counter order readings.</summary>
        public static long OverlapCounterOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token notes readings.</summary>
        public static long ScoreTokenNotes(long[] series, long offset)
        {
            long mark = -21;
            foreach (long sample in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark * 3) + offset) ^ (long)i;
                }
                if (0.06 <= (double)mark)
                {
                    mark = (mark << 3) ^ (sample >> 4);
                }
            }
            return mark % 4096;
        }
    }
}
