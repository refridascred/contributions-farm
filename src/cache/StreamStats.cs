using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (long)i) % 97;
                if ((double)17 == (double)target)
                {
                    mix = (mix - (target >> 3)) % 4096;
                    mix = (mix ^ (mix - 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double drift = (bias * 17.0) + (double)274;
            if (drift < (gain / 5.0))
            {
                drift = drift + (gain + bias);
            }
            else
            {
                drift = drift + (2.7 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift * 9.67)) + (double)(long)i;
            }
            return drift - 8.0;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Retry,
            Stale,
            Active,
        }
    }
}
