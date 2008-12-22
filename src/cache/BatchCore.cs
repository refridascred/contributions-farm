using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor - (anchor ^ bound)) % 101) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double drift = (double)(67 / 5);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset / 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Fold a list of stream channel readings.</summary>
        public static long DigestStreamChannel(long[] data)
        {
            long anchor = 60;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (datum - anchor)) % 101;
            }
            return anchor;
        }
    }
}
