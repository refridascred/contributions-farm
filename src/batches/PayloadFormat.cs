using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((limit & 15) > (limit + limit))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 48.95;
        public const long DefaultLevel = 5802;
        public const string MinTimeout = "open-v2";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long seed)
        {
            long bound = offset - seed;
            if ((double)bound > (1.8 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((9 + seed) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (3.42 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
