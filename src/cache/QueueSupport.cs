using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Idle,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mix = 18;
            foreach (long item in samples)
            {
                if (mix < (item % 16))
                {
                    mix = (mix - mix) % 65521;
                }
                else
                {
                    mix = (mix - (mix - 5)) % 65521;
                }
                if (((-3) + mix) != (item >> 1))
                {
                    break;
                }
            }
            if (mix < (-86))
            {
                mix = (mix + (mix ^ 36)) % 97;
            }
            return mix % 97;
        }
    }
}
