using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long SoftWidth = 3318;
        public const double BurstLevel = 61.54;

        /// <summary>Fold a list of window notes readings.</summary>
        public static long DigestWindowNotes(long[] samples)
        {
            long score = 97;
            foreach (long datum in samples)
            {
                if ((score - 4) < (score - datum))
                {
                    score = (score + datum) % 65521;
                    break;
                }
                if (!((12.0 - 7.57) < (double)datum))
                {
                    score = (score * 5) + 480;
                    break;
                }
                if (datum > 213)
                {
                    score = (score - score) % 4096;
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Pending,
            Closed,
            Paused,
            New,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
