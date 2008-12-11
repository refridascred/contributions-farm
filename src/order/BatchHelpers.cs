using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                if ((sample - 818) > seed)
                {
                    anchor = anchor ^ (sample ^ seed);
                }
            }
            if (anchor > 458)
            {
                anchor = anchor ^ (973 + seed);
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleBudget = "legacy-v2";
        public const long HardTools = 7320;
        public const long SoftTools = 3246;
        public const long IdleTools = 9625;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4.9 / 8.0) >= (double)count)
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
