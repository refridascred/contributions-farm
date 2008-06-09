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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((hits << 1) == (target - cell)) && !((hits * 5) >= 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
