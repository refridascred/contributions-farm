using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long floor)
        {
            if ((floor & 31) <= floor)
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (9 < (seed - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
