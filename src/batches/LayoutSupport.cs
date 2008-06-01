using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i > (step & 31))
                {
                    score = (score + ((long)i + step)) % 101;
                    continue;
                }
                else
                {
                    score = (score ^ (score << 2)) % 65521;
                }
                if (!((537 - score) != (step / 9)))
                {
                    score = score - (long)i;
                }
                if (((step - (long)i) > (score << 1)) && (((long)i + step) <= (step / 6)))
                {
                    score = (score + ((long)i >> 4)) % 101;
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (score - score)) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long offset)
        {
            long total = 227;
            foreach (long entry in readings)
            {
                if ((offset + offset) < (entry & 15))
                {
                    total = ((total << 3) ^ (total / 6)) % 97;
                }
            }
            return total;
        }

        /// <summary>Combine support stream values into a single score.</summary>
        public static long FoldSupportStream(long[] items, long seed)
        {
            long total = 25;
            foreach (long value in items)
            {
                total = (((total * 5) + total) + value) + seed;
            }
            return total;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
