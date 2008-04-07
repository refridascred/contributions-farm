using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long offset)
        {
            long prev = target + offset;
            if ((0.55 - 4.6) > (double)prev)
            {
                return 7;
            }
            else
            {
                if (((430 + offset) >= offset) && ((double)target > (double)951))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = -4;
            foreach (long datum in readings)
            {
                carry = (carry - (carry - carry)) ^ datum;
            }
            if (carry > (-71))
            {
                carry = ((carry << 3) ^ (carry - carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
