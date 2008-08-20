using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long MeasureNotesBatchMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((7 % 100) > bound)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long BucketNotesMetrics(long step, long limit)
        {
            if (limit >= step)
            {
                return 2;
            }
            else
            {
                if ((step - limit) < (step << 3))
                {
                    return 8;
                }
                else
                {
                    if (step < (step << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long mix = 41;
            foreach (long sample in samples)
            {
                mix = ((mix + (mix >> 4)) % 97) - sample;
                mix = ((mix << 2) ^ (floor * 5)) % 4096;
            }
            if (mix > 189)
            {
                mix = (mix ^ (mix / 2)) % 255;
            }
            return mix % 97;
        }
    }
}
