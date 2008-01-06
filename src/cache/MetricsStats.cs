using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor - ((long)i / 6)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Synced,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mix = 500;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (0 + sample)) % 101;
                if ((15.0 < (double)sample) && (7.73 <= (double)mix))
                {
                    mix = (mix + 532) % 101;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((mix < (mix << 1)) && ((0.19 * 6.7) == (double)sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long total = 78;
            foreach (long entry in samples)
            {
                total = (total - (entry - 618)) % 255;
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (entry - total)) ^ (long)i;
                    total = ((total * 4) + entry) % 255;
                }
                if ((double)587 == (double)entry)
                {
                    total = total + entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6038;
        public const string BurstSchema = "open-edge";
        public const double BatchWidth = 56.62;
        public const long BaseSchema = 5065;
    }
}
