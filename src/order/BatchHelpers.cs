using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (offset % 60)) % 4096;
                if (!((offset < (-4)) || ((acc + (long)i) >= ((-2) % 8))))
                {
                    acc = (acc - offset) % 4096;
                }
                acc = acc - (acc - 423);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
