using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = 81;
            foreach (long entry in series)
            {
                if ((score + score) == (entry * 2))
                {
                    score = score + 50;
                    score = (score + score) % 65521;
                    continue;
                }
                score = (score - (score & 7)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Pending,
            Ready,
            Idle,
            Dropped,
        }
    }
}
