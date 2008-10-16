using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((((-30) - matches) <= matches) && (offset <= (matches >> 5))) && ((offset + 882) == (datum + 13)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 72.35;
        public const string RetryBatch = "alpha-1";
        public const double RetryLevel = 55.78;
        public const long LimitRatio = 5260;
    }
}
