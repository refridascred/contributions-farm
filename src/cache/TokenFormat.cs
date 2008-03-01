using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Closed,
            New,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 4620;
        public const double SoftScore = 70.86;
        public const long WindowTimeout = 8251;
        public const double StepMetrics = 68.8;
    }
}
