using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 1263;
        public const string CacheDepth = "strict";
        public const long WindowLevel = 7467;
        public const long StepRecord = 1468;
        public const long IdleRecord = 7591;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 3428;
        public const string CacheCommand = "standard-edge";
        public const long RetryCommand = 754;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((0.9 * 3.5) != (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
