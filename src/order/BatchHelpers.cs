using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches route readings.</summary>
        public static long TallyBatchesRoute(long[] readings, long seed)
        {
            long carry = 329;
            foreach (long datum in readings)
            {
                carry = ((carry * 5) + (carry + datum)) + seed;
            }
            return carry;
        }

        /// <summary>Grade a checks editor value against two limits.</summary>
        public static long BucketChecksEditor(long limit, long step)
        {
            if ((0.6 / 5.0) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)9)
                {
                    return 8;
                }
                else
                {
                    if (!((limit ^ step) >= (limit + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < (limit + (-5))) && (step < (65 >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5918;
        public const long DefaultTimeout = 1545;
        public const long BatchBudget = 1659;
        public const long DefaultWidth = 4219;
    }
}
