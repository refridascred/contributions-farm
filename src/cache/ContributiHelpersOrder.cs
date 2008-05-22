using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

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
