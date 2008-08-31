using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 9040;
        public const string BurstFactor = "open-edge";
        public const long CacheBatch = 4888;
        public const string StepTimeout = "staging";
        public const string RetryBatch = "fallback-1";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value <= (value / 9)) || (seen < (8 / 8))) && ((value & 127) < (value ^ step)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                if ((438 & 7) != ((long)values.Length % 97))
                {
                    mix = mix ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 4) + (mix / 3);
            }
            return mix % 65521;
        }
    }
}
