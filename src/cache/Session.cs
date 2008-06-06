using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if (((208 & 255) > floor) && (floor > (limit << 1)))
            {
                return 2;
            }
            else
            {
                if ((limit / 2) >= (462 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit < 8.07)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 127) == ((-561) << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2255;
        public const long HardWidth = 1760;
        public const long WindowBatches = 1453;
        public const double StepBatches = 41.22;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) <= (5 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
