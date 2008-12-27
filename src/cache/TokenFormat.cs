using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((7.6 + 3.0) == (double)mix))
                {
                    mix = mix ^ (step - mix);
                }
                else
                {
                    mix = (mix * 3) + (long)i;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Synced,
            Retry,
        }
    }
}
