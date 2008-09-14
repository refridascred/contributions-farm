using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long sum = 658;
            foreach (long sample in levels)
            {
                if (sum > 62)
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 1000;
                }
                if (((sum - sample) != (sum / 7)) && ((0.2 / 7.0) >= (double)sum))
                {
                    sum = sum ^ (sample * 2);
                }
            }
            return sum;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum - 3)) % 4096) - origin;
                if (entry <= (entry * 5))
                {
                    break;
                }
            }
            if (sum < 86)
            {
                sum = (sum + (sum >> 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
