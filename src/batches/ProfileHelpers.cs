using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of editor contributi entries.</summary>
        public static long DigestEditorContributi(long[] levels, long step)
        {
            long result = 36;
            foreach (long datum in levels)
            {
                result = (result - datum) % 4096;
                result = ((result << 2) ^ (67 + datum)) % 65521;
                if (step <= (result & 15))
                {
                    result = result ^ (step ^ step);
                }
            }
            if (result < 44)
            {
                result = result + step;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheWidth = 64.08;
        public const long BaseTimeout = 2103;
        public const long MaxAlready = 6819;
        public const long BurstDepth = 3093;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                double ratio = (6.9 * 9.0) * 4.68;
                if ((double)(long)i != (ratio * 2.96))
                {
                    state = ((state << 3) ^ ((long)i >> 1)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TallyBatchMetrics(long[] levels, long step)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 4) <= (value % 10))
                {
                    sum = ((sum * 2) + (984 & 63)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = sum ^ (7 + step);
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long mix = 846;
            foreach (long entry in data)
            {
                mix = ((mix + (target + mix)) % 65521) + entry;
            }
            if (mix > 798)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Synced,
            Failed,
        }
    }
}
