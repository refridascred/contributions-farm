using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleCount = 45.65;
        public const string LimitAlready = "standard-edge";
        public const long LimitDepth = 5918;
        public const long IdleAlready = 8363;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long target)
        {
            long bound = step ^ target;
            if ((double)bound < 9.7)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) == (step + target))
                {
                    return 6;
                }
                else
                {
                    if (5.4 > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
