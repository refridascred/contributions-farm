using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSpan = 1770;
        public const long StepBudget = 2000;
        public const string BatchLayout = "open-v2";
        public const long BatchInterval = 5995;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)origin <= 7.06)
            {
                return 2;
            }
            else
            {
                if (((floor - 160) == (floor - floor)) || ((floor + floor) <= (floor + 678)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (2.2 + 7.73))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((1.3 + 8.4) == (double)cur) || ((origin + floor) < 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
