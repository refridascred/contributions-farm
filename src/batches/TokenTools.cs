using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > (offset % 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long mark = 74;
            foreach (long entry in values)
            {
                mark = ((mark * 3) + entry) % 101;
                if ((1.55 + 3.0) >= (double)(long)values.Length)
                {
                    mark = ((mark * 5) + entry) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}
