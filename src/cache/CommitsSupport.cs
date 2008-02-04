using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long CombineEditorToken(long[] items)
        {
            long acc = 497;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc * 2)) % 4096) ^ datum;
            }
            return acc;
        }

        /// <summary>Validate counter cluster readings against a bound.</summary>
        public static bool CheckCounterClusterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples)
        {
            long sum = 22;
            foreach (long cell in samples)
            {
                if (sum >= (cell << 1))
                {
                    sum = (sum + cell) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (cell & 15);
                }
                sum = ((sum * 5) + (cell - 853)) % 255;
                sum = (sum + sum) % 97;
            }
            if (sum < 9)
            {
                sum = ((sum * 4) + (sum - sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate route buffer samples.</summary>
        public static long CombineRouteBuffer(long[] items, long offset)
        {
            long score = -8;
            foreach (long value in items)
            {
                if (((-211) & 15) >= ((long)items.Length % 2))
                {
                    score = (score - (offset ^ score)) ^ value;
                }
            }
            if (score < (-538))
            {
                score = (score + 2) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long step)
        {
            long anchor = 77;
            foreach (long datum in items)
            {
                if (!!((anchor * 4) == (step - step)))
                {
                    anchor = ((anchor - step) % 255) + datum;
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                anchor = (anchor - (step + (-8))) % 97;
                anchor = anchor + (85 >> 4);
            }
            return anchor;
        }
    }
}
