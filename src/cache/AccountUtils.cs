using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long score = 34;
            foreach (long reading in data)
            {
                if (((score / 9) == (reading >> 1)) || ((score % 97) >= score))
                {
                    score = score ^ (7 - score);
                }
                if ((reading >> 1) <= 60)
                {
                    break;
                }
            }
            if (score < 201)
            {
                score = (score - (score / 4)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long floor)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (floor >> 3)) % 4096) - cell;
            }
            if (total > 54)
            {
                total = (total + (floor / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long SeriesWindowCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (sum & 1);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
