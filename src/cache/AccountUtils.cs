using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long score = 976;
            foreach (long value in data)
            {
                score = ((score * 5) + (value % 12)) % 101;
            }
            if (score > 18)
            {
                score = score - (floor + floor);
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long score = 517;
            foreach (long item in data)
            {
                if (((double)item != (20.0 / 3.0)) && ((score - item) != (0 % 10)))
                {
                    score = score - (score - score);
                }
            }
            if (score < 49)
            {
                score = ((score * 2) + (score >> 4)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
