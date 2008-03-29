using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long IterateCommitsChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((mix >> 1) == (mix & 3)))
                {
                    mix = (mix ^ (offset + offset)) % 4096;
                }
                if (((offset << 2) >= offset) && (offset <= (mix & 15)))
                {
                    mix = ((mix << 2) ^ (long)i) % 255;
                }
                else
                {
                    mix = mix ^ (mix + mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double bias2 = (bias - bias) / 6.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
