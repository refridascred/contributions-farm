using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits metrics counter forward.</summary>
        public static long RollCommitsMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (target - 68)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + (-51)) <= 0)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
