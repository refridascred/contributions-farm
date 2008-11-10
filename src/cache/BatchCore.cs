using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TallyRecordToken(long[] readings)
        {
            long mix = 295;
            foreach (long cell in readings)
            {
                if ((6 ^ mix) < (mix * 3))
                {
                    mix = (mix ^ (mix - mix)) + cell;
                }
            }
            if (mix > 884)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items)
        {
            long score = 2;
            foreach (long item in items)
            {
                score = score - (score >> 2);
                if (((score - item) <= (score & 3)) || ((score * 3) > score))
                {
                    score = score - (110 * 3);
                }
            }
            if (score > 674)
            {
                score = score ^ (82 - score);
            }
            return score % 1000;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Idle,
            Locked,
            Stale,
            Ready,
        }
    }
}
