using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((26 - cur) > seed2)
            {
                return 3;
            }
            else
            {
                if (!((seed - 2) == (cur - 6)))
                {
                    return 2;
                }
                else
                {
                    if ((double)cur < (9.3 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool GuardBatchesContributiRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
