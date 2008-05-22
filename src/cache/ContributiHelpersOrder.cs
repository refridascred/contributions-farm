using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchScore = 77.4;
        public const double DefaultCount = 83.21;
        public const string IdleSession = "open";
        public const long BurstSession = 9168;
        public const long DefaultSession = 7758;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long offset)
        {
            long carry = 47;
            foreach (long value in data)
            {
                if ((carry <= (916 - offset)) || (offset >= (value / 2)))
                {
                    carry = carry - (offset % 24);
                }
            }
            return carry;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long TallySchemaQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
