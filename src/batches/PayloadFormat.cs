using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            long bound = seed + target;
            if ((target * 3) > (bound & 3))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) <= (seed - 9))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 5912;
        public const long SoftInterval = 3361;
        public const long BurstNotes = 9749;
        public const long MaxWidth = 280;
        public const double WindowCount = 94.92;

        /// <summary>Measure how many graph channel samples are out of range.</summary>
        public static long AuditGraphChannelMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((limit + (long)samples.Length) <= limit) && (((95 * 5) != (reading << 1)) || ((4 << 2) <= (tally * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
