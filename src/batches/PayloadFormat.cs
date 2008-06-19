using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count counter buffer pairs that satisfy a relation.</summary>
        public static long MatchCounterBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] values, long origin)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (mix ^ (origin - mix)) + value;
                mix = mix + (85 % 97);
                mix = (mix * 4) + 562;
            }
            if (mix > 422)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits >> 3) >= sample) && !(679 > (hits << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
