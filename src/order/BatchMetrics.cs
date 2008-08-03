using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long mix = 273;
            foreach (long cell in levels)
            {
                if (!(mix < (23 % 7)))
                {
                    mix = (mix * 5) + (cell - mix);
                }
                mix = (mix * 3) + (cell >> 5);
            }
            if (mix > 192)
            {
                mix = ((mix << 2) ^ (mix / 6)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long DeriveFormatSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long seed)
        {
            long anchor = 74;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ (long)levels.Length) ^ datum) + seed;
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long score = 7;
            foreach (long item in samples)
            {
                score = (score + (item + step)) % 4096;
                if ((item % 60) >= item)
                {
                    score = (score + (score % 24)) % 255;
                }
                else
                {
                    score = (score + (step << 3)) % 101;
                }
            }
            if (score > 923)
            {
                score = (score + (step << 1)) % 4096;
            }
            return score % 1000;
        }
    }
}
