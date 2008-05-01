using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 3) == (entry * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((long)data.Length != (cell * 2)) || (hits >= (seed ^ cell))) || ((70 >> 1) == (cell & 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits batch counter forward.</summary>
        public static long StepCommitsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)mix < 0.14)
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (mix & 31);
                }
                mix = (mix + (85 - (long)i)) % 101;
                if ((step - mix) <= (-77))
                {
                    mix = ((mix << 2) ^ step) % 97;
                    mix = (mix * 4) + 87;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long offset)
        {
            long mix = 187;
            foreach (long value in samples)
            {
                mix = ((mix + (value % 3)) % 4096) - offset;
            }
            return mix % 4096;
        }
    }
}
