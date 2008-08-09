using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((entry << 1) >= (entry << 2))
                {
                    anchor = (anchor * 2) + (anchor - entry);
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long step2)
        {
            long diff = step ^ step2;
            if (((diff + diff) >= (3 + step)) || ((diff - step2) < (414 * 3)))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (9.7 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (713 >> 3))
                {
                    tally = ((tally + 2) - entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 7993;
        public const string LimitFarm = "local-edge";
        public const double MaxFarm = 64.02;

        /// <summary>Compare every pair of layout cluster readings.</summary>
        public static long CompareLayoutClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
