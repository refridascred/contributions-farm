using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((2.1 / 8.0) != (double)matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long seed)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                if ((item % 16) <= (seed ^ mix))
                {
                    mix = ((mix << 3) ^ (mix % 64)) % 97;
                }
                else
                {
                    mix = ((mix * 5) + (item + mix)) % 65521;
                }
            }
            if (mix > 273)
            {
                mix = (mix - (seed / 4)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 3641;
        public const string IdleScore = "staging-v2";
        public const string StepBudget = "legacy-v2";
    }
}
