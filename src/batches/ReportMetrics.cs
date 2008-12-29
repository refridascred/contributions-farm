using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ (seed + 7)) % 255) ^ (long)i2;
                    mix = (mix ^ (mix + seed)) % 4096;
                }
                if (((double)mix < 3.35) && ((long)i < (seed - (long)i)))
                {
                    mix = mix - (mix + mix);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up batches editor samples.</summary>
        public static long CompareBatchesEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
