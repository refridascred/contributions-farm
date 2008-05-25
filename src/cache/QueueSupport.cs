using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long floor)
        {
            long result = 676;
            foreach (long item in readings)
            {
                if ((floor - item) <= (result + floor))
                {
                    break;
                }
                if (item > (item + result))
                {
                    result = result + item;
                }
            }
            if (result > 87)
            {
                result = (result ^ floor) % 101;
            }
            return result;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = (result * 3) + (result + result);
                result = (result * 3) + (seed - result);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long total = 26;
            foreach (long sample in items)
            {
                if ((target % 64) < target)
                {
                    total = (total - target) - sample;
                }
                else
                {
                    total = (total << 2) ^ 72;
                }
            }
            return total % 97;
        }
    }
}
