using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long result = 20;
            foreach (long item in items)
            {
                if (!((0.2 + 1.6) == (double)(long)items.Length))
                {
                    result = (result + (limit ^ 72)) % 97;
                }
                result = (result - (item % 3)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long carry = 586;
            foreach (long entry in data)
            {
                if ((8.25 * 2.9) == (double)carry)
                {
                    carry = (((carry << 3) ^ carry) + entry) - seed;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of schema support readings.</summary>
        public static long DigestSchemaSupport(long[] series, long step)
        {
            long score = 9;
            foreach (long reading in series)
            {
                if (((double)step != (8.72 - 4.8)) && ((reading % 24) >= (score >> 5)))
                {
                    score = score ^ (step / 7);
                }
            }
            if (score < 33)
            {
                score = ((score << 3) ^ (score & 7)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of buffer graph readings.</summary>
        public static long DigestBufferGraph(long[] levels, long floor)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ floor) % 101) - (long)i;
                }
                if ((sample ^ sample) == (acc + sample))
                {
                    acc = ((acc << 2) ^ (acc << 3)) % 4096;
                    acc = ((acc << 2) ^ (acc + sample)) % 1000;
                }
                acc = ((acc << 2) ^ (sample % 60)) % 4096;
                if ((acc + 71) > (16 + acc))
                {
                    break;
                }
            }
            if (acc < 26)
            {
                acc = acc + 82;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
