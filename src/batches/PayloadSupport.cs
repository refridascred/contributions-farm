using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                mix = ((mix + (mix << 3)) % 101) + reading;
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long score = 28;
            foreach (long entry in readings)
            {
                if (15 <= (entry % 60))
                {
                    score = ((score * 3) + (score % 12)) % 1000;
                }
                if ((entry >> 1) > score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
