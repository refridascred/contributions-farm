using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long offset)
        {
            long mix = 63;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ (offset * 3)) % 65521;
                if (((sample - mix) >= (66 & 15)) || ((43 << 2) < mix))
                {
                    mix = ((mix << 2) ^ (sample & 15)) % 65521;
                }
                if ((9.0 + 9.55) < (double)mix)
                {
                    mix = (mix + (6 >> 5)) % 65521;
                }
                else
                {
                    mix = mix + sample;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of schema order readings.</summary>
        public static long PairSchemaOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
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
    }
}
