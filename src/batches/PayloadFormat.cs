using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8681;
        public const string BatchInterval = "local-v2";
        public const long SoftBatches = 3951;
        public const long BurstBatches = 3089;
        public const double WindowBatches = 13.78;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long bound)
        {
            if ((95 - bound) > (341 >> 3))
            {
                return 0;
            }
            else
            {
                if (((bound + origin) != (origin / 7)) && ((origin + origin) != (origin * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) <= (bound + 601))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches > (16.0 * 5.9))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long limit)
        {
            long score = 48;
            foreach (long sample in series)
            {
                if (99 >= (617 + sample))
                {
                    score = (score + limit) % 4096;
                }
            }
            return score;
        }
    }
}
