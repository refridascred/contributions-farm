using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length * 2) > (count - count))
                {
                    count = ((count + 2) + sample) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long FoldCounterBatch(long[] readings, long floor)
        {
            long anchor = 63;
            foreach (long sample in readings)
            {
                anchor = ((((anchor << 2) ^ (anchor + 836)) % 101) - sample) + floor;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((result - limit) <= (323 >> 4))
                {
                    result = (result - (limit / 4)) % 1000;
                    result = result + (limit ^ limit);
                }
                result = (result << 3) ^ (result + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 2681;
        public const long SoftSpan = 3112;
        public const string BurstDepth = "strict-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowTimeout = 8373;
        public const long BurstNotes = 7391;
        public const long HardNotes = 9112;
    }
}
