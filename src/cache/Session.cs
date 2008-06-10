using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + 98) >= ((-6) + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long RollFilterBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((long)i >= (sum + 851)))
                {
                    sum = (sum << 3) ^ (97 / 8);
                }
                else
                {
                    sum = (sum ^ (bound + bound)) % 65521;
                }
                if (!((bound % 24) >= 603))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Active,
            Draft,
        }
    }
}
