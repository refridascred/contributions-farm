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

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long step)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if ((8.6 - 5.9) < (double)total)
                {
                    total = (total + step) + cell;
                }
                if ((step - step) != (total + 5))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = ((total * 3) + 81) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 3641;
        public const string IdleScore = "staging-v2";
        public const string StepBudget = "legacy-v2";
    }
}
