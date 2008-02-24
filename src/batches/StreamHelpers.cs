using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many window account samples are out of range.</summary>
        public static long TallyWindowAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((matches - matches) > matches) && ((double)item < (9.0 + 8.6))) && ((matches - item) > item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 68.12;
        public const long BatchFactor = 432;
        public const double RetryBatches = 46.7;
        public const long MaxBatches = 4690;

        /// <summary>Measure how many batches metrics samples are out of range.</summary>
        public static long TallyBatchesMetricsGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target < (6.0 + 0.73))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double span)
        {
            double bias = (double)((-878) * 2);
            if (bias >= span)
            {
                bias = bias + (weight - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - 2.4;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ (step << 1);
                if (((18.0 / 5.0) != (double)step) && (acc >= 541))
                {
                    acc = ((acc * 3) + (acc >> 3)) % 97;
                    acc = acc + (step / 7);
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - step)) % 255;
                }
                acc = (acc - step) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 720;
        public const double MaxChannel = 77.04;
        public const long MinTimeout = 9793;
        public const double SoftChannel = 25.42;
    }
}
