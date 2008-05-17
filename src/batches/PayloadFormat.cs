using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((long)items.Length != (step << 2)) && ((hits << 1) >= (entry * 2))) && (step <= (step - (-5))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitTimeout = 5644;
        public const long LimitSupport = 2612;
        public const long BurstSupport = 6370;
        public const string BaseSupport = "strict-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 880;
        public const long StepSize = 6488;
        public const double BaseWidth = 5.4;
        public const double RetryScore = 23.39;
    }
}
