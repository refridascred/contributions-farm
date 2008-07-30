using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry <= (double)665))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long step)
        {
            if (limit >= 38)
            {
                return 8;
            }
            else
            {
                if ((limit + limit) < (368 >> 5))
                {
                    return 0;
                }
                else
                {
                    if (!((84 + step) < (step % 97)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit < 9) || ((step - step) > (limit % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
