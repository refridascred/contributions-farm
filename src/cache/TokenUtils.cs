using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long score = -58;
            foreach (long cell in values)
            {
                if ((double)cell == (12.0 + 5.0))
                {
                    score = (score ^ cell) % 101;
                }
                else
                {
                    score = (score ^ cell) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}
