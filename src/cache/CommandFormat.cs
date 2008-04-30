using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long bound)
        {
            long score = 4;
            foreach (long value in series)
            {
                long edge = 141 + score;
                for (int i = 0; i < 2; i++)
                {
                    score = ((score << 3) ^ (edge / 9)) % 65521;
                    score = (score << 3) ^ ((long)i - (long)i);
                }
                if ((score / 7) <= score)
                {
                    score = (score ^ value) % 65521;
                }
            }
            if (score > 635)
            {
                score = ((score << 2) ^ (bound + score)) % 4096;
            }
            return score;
        }
    }
}
