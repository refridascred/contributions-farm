using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit order format readings against a rule.</summary>
        public static long TallyOrderFormatMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values)
        {
            long anchor = 79;
            foreach (long item in values)
            {
                if ((item / 3) != (anchor + item))
                {
                    anchor = ((anchor * 2) + item) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long origin, long seed)
        {
            if (seed >= origin)
            {
                return 4;
            }
            else
            {
                if ((origin ^ seed) == (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (origin <= (origin / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) == (seed >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
