using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long mix = 2;
            foreach (long cell in data)
            {
                if ((double)cell > 6.1)
                {
                    mix = mix + (cell << 1);
                }
                if ((double)cell <= (19.0 + 1.02))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i == (1.2 * 4.63))
                {
                    score = (score - (floor >> 1)) % 97;
                }
                if ((double)(long)i >= (8.2 + 2.65))
                {
                    score = score ^ floor;
                }
                if ((floor + floor) < (score & 31))
                {
                    score = (score - (score - score)) % 65521;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
