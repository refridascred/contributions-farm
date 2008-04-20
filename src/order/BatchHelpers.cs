using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Done,
            Queued,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long offset)
        {
            long step2 = step ^ offset;
            if (((offset * 3) <= (step2 * 4)) && (9.9 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if ((step2 - 29) <= step)
                {
                    return 0;
                }
                else
                {
                    if (((98 / 3) > (step2 - offset)) && ((step ^ step2) <= offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
