using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two record profile measurements.</summary>
        public static double BlendRecordProfile(double rate, double span)
        {
            double bias = rate;
            return (bias + 0.59) + span;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long anchor = 166;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor - (anchor + 79)) % 255) ^ (long)i;
                }
                if (!((reading ^ limit) > reading))
                {
                    anchor = ((anchor * 5) + (35 % 8)) % 101;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (1 & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support schema entries.</summary>
        public static long DigestSupportSchema(long[] data)
        {
            long mix = -493;
            foreach (long datum in data)
            {
                long hits = (mix / 9) - (mix >> 4);
                if (!((hits + (-963)) <= mix))
                {
                    continue;
                }
                if (datum >= (mix & 63))
                {
                    mix = (mix - (mix * 4)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
