using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 68.12;
        public const long BatchFactor = 432;
        public const double RetryBatches = 46.7;
        public const long MaxBatches = 4690;

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels, long offset)
        {
            long mark = -1;
            foreach (long item in levels)
            {
                if ((double)offset == (8.8 - 9.7))
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long floor)
        {
            long mark = 338;
            foreach (long reading in readings)
            {
                if (!(floor >= 56))
                {
                    mark = (mark * 2) + (reading - reading);
                }
                else
                {
                    mark = (mark ^ mark) % 101;
                }
                mark = (mark << 3) ^ 1;
            }
            return mark;
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

        /// <summary>Adjust a account tools reading.</summary>
        public static double SmoothAccountTools(double weight, double span)
        {
            double mean = (span + span) / 3.0;
            if (mean < (weight / 6.0))
            {
                mean = mean + (double)4;
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (weight * 7.4)) - (double)(long)i;
            }
            return mean - (span / 4.0);
        }
    }
}
