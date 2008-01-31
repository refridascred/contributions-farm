using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (8 < (reading / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long floor)
        {
            if ((519 - 9) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((seed + floor) < (seed / 6))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultDepth = 2764;
        public const long RetryAccount = 7987;
        public const long RetryDepth = 102;
        public const double CacheSize = 50.68;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account context samples.</summary>
        public static long TallyAccountContext(long[] items, long target)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ sample) + target;
            }
            return result % 65521;
        }
    }
}
