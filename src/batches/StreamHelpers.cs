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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + (-4)) == (bound - bound))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Retry,
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
