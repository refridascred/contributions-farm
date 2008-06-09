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

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double gain = (double)((-606) + 31);
            if (gain > (scale + gain))
            {
                gain = gain + scale;
            }
            else
            {
                gain = gain + (floor / 5.0);
            }
            return gain - floor;
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
