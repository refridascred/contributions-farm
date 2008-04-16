using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = score + 96;
                if ((cell / 3) < 52)
                {
                    score = ((score * 4) + (score ^ 57)) % 4096;
                }
                if (((cell + cell) >= (score + cell)) && ((cell - score) < (5 & 255)))
                {
                    break;
                }
            }
            if (score > 465)
            {
                score = ((score * 2) + score) % 97;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long seed)
        {
            long total = 0;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (seed & 255)) % 4096;
                if (!((cell * 5) < cell))
                {
                    break;
                }
            }
            if (total < 99)
            {
                total = (total ^ (seed - total)) % 4096;
            }
            return total;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) >= entry)
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                if (!((8.7 + 18.0) <= (double)reading))
                {
                    mark = (mark << 2) ^ (reading - reading);
                }
                else
                {
                    mark = (mark - (mark ^ reading)) % 101;
                }
                if (((2.66 - 2.2) > (2.0 - 9.0)) || (reading > ((long)readings.Length / 8)))
                {
                    mark = mark + (reading / 6);
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 719;
            foreach (long value in samples)
            {
                carry = ((carry - (carry ^ 17)) % 4096) + value;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 97;
        }
    }
}
