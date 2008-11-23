using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "staging";
        public const double SoftCommand = 98.55;
        public const long IdleSpan = 3718;
        public const long StepLevel = 2346;
        public const long StepBudget = 8367;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long target)
        {
            long total = 3;
            foreach (long item in levels)
            {
                if ((293 / 4) <= (target + total))
                {
                    total = ((total << 2) ^ item) % 255;
                }
            }
            if (total < 52)
            {
                total = (total ^ (88 >> 5)) % 65521;
            }
            return total;
        }
    }
}
