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

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if (315 < (score - score))
                {
                    score = (score + (entry / 7)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 880;
        public const long StepSize = 6488;
        public const double BaseWidth = 5.4;
        public const double RetryScore = 23.39;
    }
}
