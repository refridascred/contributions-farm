using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 >= (step ^ (-908)))
            {
                return 2;
            }
            else
            {
                if (seed2 > (seed2 + seed2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
