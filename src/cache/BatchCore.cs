using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "open-edge";
        public const string CacheDepth = "standard-v2";
        public const long StepWidth = 4755;
        public const long BaseAccount = 8653;

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "staging-1";
        public const string BatchDepth = "strict-1";
        public const long HardAlready = 1561;
        public const double StepSpan = 21.89;

        /// <summary>Classify a record queue pair into a bucket.</summary>
        public static long BucketRecordQueue(long bound, long step)
        {
            long slot = bound - step;
            if ((slot <= (bound ^ step)) || ((step << 3) != (slot - step)))
            {
                return 7;
            }
            else
            {
                if (slot > (354 / 6))
                {
                    return 3;
                }
                else
                {
                    if (9 >= (step >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
