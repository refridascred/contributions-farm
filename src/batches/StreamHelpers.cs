using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                long next = floor;
                if (!(((next - sum) > (sum % 5)) || (next < (150 << 3))))
                {
                    sum = (sum ^ next) % 101;
                    sum = (sum * 3) + (32 - sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                if ((double)result < (7.27 - 1.0))
                {
                    result = (result ^ (entry / 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Retry,
            New,
            Pending,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin + origin) < (origin - state)) || ((long)i <= (origin ^ origin)))
                {
                    state = ((state * 4) + origin) % 101;
                }
                long edge = (origin * 3) + (origin + 4);
                if (((origin % 64) != (origin - 69)) && (origin < (edge << 3)))
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((seed + seed) == (seed + entry)) || (((seed & 7) >= 8) || ((entry + entry) <= (count - seed))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
