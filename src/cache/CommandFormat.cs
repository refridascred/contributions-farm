using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long CombineAccountContributi(long[] samples)
        {
            long state = 588;
            foreach (long cell in samples)
            {
                if ((state * 5) >= (cell / 7))
                {
                    continue;
                }
                else
                {
                    state = ((state * 5) + (90 ^ state)) % 1000;
                    state = (state ^ (cell % 64)) % 65521;
                }
                state = state + (state % 12);
            }
            if (state < 985)
            {
                state = (state * 3) + state;
            }
            return state;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((double)hits > (double)reading) && ((double)hits <= 17.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
