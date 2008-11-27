using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + ((long)i - acc)) % 97;
                acc = acc + (target + (long)i);
                if (target < (target ^ acc))
                {
                    acc = acc - 9;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < (datum >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 4) != (mix << 2))
                {
                    mix = (mix ^ ((long)i % 8)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
