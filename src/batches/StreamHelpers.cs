using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((bound % 97) != (bound % 60))
            {
                return 6;
            }
            else
            {
                if ((prev & 255) <= (seed ^ prev))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 68.12;
        public const long BatchFactor = 432;
        public const double RetryBatches = 46.7;
        public const long MaxBatches = 4690;

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const double StepBudget = 22.96;
        public const long DefaultReport = 1203;

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
