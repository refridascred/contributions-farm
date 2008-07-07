using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data)
        {
            long acc = 10;
            foreach (long item in data)
            {
                acc = ((acc * 5) + (acc + acc)) - item;
            }
            return acc % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
