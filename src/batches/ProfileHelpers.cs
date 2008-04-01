using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a stats cache counter forward.</summary>
        public static long IterateStatsCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                double weight = (5.16 / 3.0) * 3.0;
                sum = ((sum << 3) ^ (sum * 2)) % 65521;
                if ((6.79 - weight) != (weight * 2.56))
                {
                    weight = weight - weight;
                    weight = weight - weight;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Queued,
            Active,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits > (item + item)) && ((item >= (item ^ hits)) || ((55 + item) <= item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < 297)
                {
                    result = (result << 2) ^ (origin & 63);
                }
                if ((result / 5) > (result ^ (-48)))
                {
                    result = ((result * 3) + ((long)i + result)) % 4096;
                    result = (result ^ (origin - 2)) % 97;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
