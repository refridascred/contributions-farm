using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                long seen = target;
                mark = mark + seen;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "fallback-1";
        public const long LimitCount = 198;
        public const string HardWidth = "primary";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches <= 4.0))
                {
                    matches = ((matches + 2) ^ value) + offset;
                }
            }
            return matches;
        }
    }
}
