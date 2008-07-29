using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 1) != (964 / 9))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels, long step)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                mix = (((mix * 4) + (74 / 4)) % 101) + sample;
            }
            if (mix < 785)
            {
                mix = (mix << 3) ^ (step % 64);
            }
            return mix % 4096;
        }
    }
}
