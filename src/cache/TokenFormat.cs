using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((result + target) <= (target - (-3))))
                {
                    result = result ^ result;
                    result = (result - (target + result)) % 97;
                }
                else
                {
                    result = (result + target) % 65521;
                }
                result = (result - ((long)i + target)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)origin <= (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
